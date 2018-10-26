using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MetroFramework.Forms;
using MetroFramework;
using System.Diagnostics;

namespace BackUpWindowsForm
{
    public partial class Form1 : MetroForm
    {
        BackUpEntities _backUpEntities;
        public Form1()
        {

            InitializeComponent();

            Display();

        }


        public void Display()   // Display Method is a common method to bind the Student details in datagridview after save,update and delete operation perform.
        {
            using (BackUpEntities _entity = new BackUpEntities())
            {
                metroGrid1.DataSource = _entity.FTPs.ToList();
            }
        }


        private void LoadDatabase()
        {
            _backUpEntities = new BackUpEntities();
            _backUpEntities.FTPs.Load();
        }
        private void BackupFTP(FTP fTP)
        {
            NetworkCredential credentials = new NetworkCredential(fTP.UserName, fTP.Password);
            fTP.FolderSave = fTP.FolderSave + "\\" + DateTime.Now.ToString("yyyyMMddhhmm");
            if (!Directory.Exists(fTP.FolderSave))
            {
                Directory.CreateDirectory(fTP.FolderSave);
            }
            
            DownloadFtpDirectory(fTP.FTPServer, credentials, fTP.FolderSave);
            
        }
        private void DownloadFtpDirectory(string url, NetworkCredential credentials, string localPath)
        {
            
            FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create(url);
            listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            listRequest.Credentials = credentials;

            List<string> lines = new List<string>();

            using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
            using (Stream listStream = listResponse.GetResponseStream())
            using (StreamReader listReader = new StreamReader(listStream))
            {
                while (!listReader.EndOfStream)
                {
                    lines.Add(listReader.ReadLine());
                }
            }

            foreach (string line in lines)
            {
                
                string[] tokens =
                    line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[8];
                string permissions = tokens[0];

                string localFilePath = Path.Combine(localPath, name);
                string fileUrl = url + name;

                if (permissions[0] == 'd')
                {
                    if (!Directory.Exists(localFilePath))
                    {
                        Directory.CreateDirectory(localFilePath);
                    }

                    DownloadFtpDirectory(fileUrl + "/", credentials, localFilePath);
                }
                else
                {
                    again:
                    try
                    {
                        
                        FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                        downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                        downloadRequest.Credentials = credentials;

                        using (FtpWebResponse downloadResponse =
                                  (FtpWebResponse)downloadRequest.GetResponse())
                        using (Stream sourceStream = downloadResponse.GetResponseStream())
                        using (Stream targetStream = File.Create(localFilePath))
                        {
                            byte[] buffer = new byte[10240];
                            int read;
                            while ((read = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                targetStream.Write(buffer, 0, read);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Download failed and download again: " + fileUrl);
                        goto again;
                    }
                }
                Console.WriteLine("Download success: " + fileUrl);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FTP stu = new FTP();
            stu.Name = txtBoxName.Text;
            stu.UserName = txtBoxUserName.Text;
            stu.Password = txtBoxPass.Text;
            stu.FTPServer = txtFTPServer.Text;
            stu.FolderSave = txtBoxFolderSave.Text;
            stu.Schedule = Convert.ToInt32(cbSchedule.Text);
            stu.StartDT = DateTime.Parse(dtStartDT.Text);
            if (cBoxType.Text == "FTP")
                stu.Type = 1;
            else
                stu.Type = 2;
            stu.DatabaseName = txtBoxDatabaseName.Text;
            bool result = SaveFTPDetails(stu); // calling SaveStudentDetails method to save the record in table.Here passing a student details object as parameter  
            ShowStatus(result, "Save");
        }
        public bool SaveFTPDetails(FTP Stu) // calling SaveStudentMethod for insert a new record  
        {
            bool result = false;
            using (BackUpEntities _entity = new BackUpEntities())
            {
                _entity.FTPs.Add(Stu);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
        public void ShowStatus(bool result, string Action) // validate the Operation Status and Show the Messages To User  
        {
            if (result)
            {
                if (Action.ToUpper() == "SAVE")
                {
                    MetroMessageBox.Show(this, "Đã sau tất cả thành công", "Sao lưu",MessageBoxButtons.OK,MessageBoxIcon.Information,100);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MetroMessageBox.Show(this, "Updated Successfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                }
                else
                {
                    MetroMessageBox.Show(this, "Deleted Successfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
            Display();
        }
        public void ClearFields() // Clear the fields after Insert or Update or Delete operation  
        {
            txtBoxName.Text = "";
            txtFTPServer.Text = "";
            txtBoxUserName.Text = "";
            txtBoxPass.Text = "";
            txtBoxFolderSave.Text = "";
            cbSchedule.Text = "";
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in metroGrid1.SelectedRows) // foreach datagridview selected rows values  
                {
                    lbID.Text = row.Cells[0].Value.ToString();
                    txtBoxName.Text = row.Cells[1].Value.ToString();
                    txtFTPServer.Text = row.Cells[2].Value.ToString();
                    txtBoxUserName.Text = row.Cells[3].Value.ToString();
                    txtBoxPass.Text = row.Cells[4].Value.ToString();
                    txtBoxFolderSave.Text = row.Cells[5].Value.ToString();
                    cbSchedule.Text = row.Cells[6].Value.ToString();
                    txtBoxDatabaseName.Text = row.Cells[8].Value.ToString();
                    var type = row.Cells[7].Value.ToString();
                    if (type == "1")
                        cBoxType.Text = "FTP";
                    else
                        cBoxType.Text = "MongoDB";
                    dtStartDT.Text = row.Cells[9].Value.ToString();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FTP stu = SetValues(Int32.Parse(lbID.Text), txtBoxName.Text, txtBoxUserName.Text, txtBoxPass.Text, txtFTPServer.Text, txtBoxFolderSave.Text, cbSchedule.Text, dtStartDT.Text, cBoxType.Text, txtBoxDatabaseName.Text); // Binding values to StudentInformationModel  
            bool result = UpdateFTPDetails(stu); // calling UpdateStudentDetails Method  
            ShowStatus(result, "Update");
        }
        public FTP SetValues(int Id, string Name, string UserName, string Password, string FTPServer, string FolderSave, string Schedule, string StartDT, string Type, string DatabaseName) //Setvalues method for binding field values to StudentInformation Model class  
        {
            FTP stu = new FTP();
            stu.Id = Id;
            stu.Name = Name;
            stu.UserName = UserName;
            stu.Password = Password;
            stu.FTPServer = FTPServer;
            stu.FolderSave = FolderSave;
            stu.Schedule = Convert.ToInt32(Schedule);
            stu.StartDT = DateTime.Parse(StartDT);
            stu.DatabaseName = DatabaseName;
            if (Type == "FTP")
                stu.Type = 1;
            else
                stu.Type = 2;
            return stu;
        }
        public bool UpdateFTPDetails(FTP Stu) // UpdateStudentDetails method for update a existing Record  
        {
            bool result = false;
            using (BackUpEntities _entity = new BackUpEntities())
            {
                FTP _student = _entity.FTPs.Where(x => x.Id == Stu.Id).SingleOrDefault();
                _student.Name = Stu.Name;
                _student.UserName = Stu.UserName;
                _student.Password = Stu.Password;
                _student.FTPServer = Stu.FTPServer;
                _student.FolderSave = Stu.FolderSave;
                _student.Schedule = Convert.ToInt32(Stu.Schedule);
                _student.Type = Stu.Type;
                _student.DatabaseName = Stu.DatabaseName;
                _student.StartDT = Stu.StartDT;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FTP stu = SetValues(Int32.Parse(lbID.Text), txtBoxName.Text, txtBoxUserName.Text, txtBoxPass.Text, txtFTPServer.Text, txtBoxFolderSave.Text, cbSchedule.Text, dtStartDT.Text, cBoxType.Text, txtBoxDatabaseName.Text); // Binding values to StudentInformationModel  
            bool result = DeleteFTPDetails(stu); //Calling DeleteStudentDetails Method  
            ShowStatus(result, "Delete");
        }
        public bool DeleteFTPDetails(FTP Stu) // DeleteStudentDetails method to delete record from table  
        {
            bool result = false;
            using (BackUpEntities _entity = new BackUpEntities())
            {
                FTP _student = _entity.FTPs.Where(x => x.Id == Stu.Id).SingleOrDefault();
                _entity.FTPs.Remove(_student);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (BackUpEntities _entity = new BackUpEntities())
            {
                foreach (var item in _entity.FTPs.ToList())
                {
                    if (item.Type == 1)
                    {
                        BackupFTP(item);
                    }
                    if (item.Type == 2)
                        BackupMongodb(item);
                }
            }
            Console.WriteLine("Backup successfully");
            MetroMessageBox.Show(this, "Backup successfully", "Sao lưu", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
        }
        private void BackupMongodb(FTP ftp)
        {
            string arguments = "--host " + ftp.FTPServer + " --username " + ftp.UserName + " --password " + ftp.Password + " -o MongoDump\\" + DateTime.Now.ToString("yyyyMMddhhmm") + " --db "+ftp.DatabaseName;// ./path/to/dump/";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                //Right under this directory, You will have to find MongoDump Directory
                WorkingDirectory = ftp.FolderSave,
                //The program you want to execute. Because you have added mongodump.exe to your environment path, you don't have to give the cmd line absolute path to find the executable.
                FileName = @"C:\Program Files\MongoDB\Server\4.0\bin\mongodump",
                Arguments = arguments,
                //CreateNoWindow = true,  //Once I set the process started by windows schedule, the prompt window will not show. If you have this problem you can try to set this parameter. 
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            //Its a class to manipulate cmd line
            using (Process exeProcess = Process.Start(startInfo))
            {
                if (exeProcess != null) exeProcess.WaitForExit();
                //We don't need any return words, therefore you can ignore the code below.
                while (!exeProcess.StandardOutput.EndOfStream)
                {
                    string line = exeProcess.StandardOutput.ReadLine();
                    // do something with line
                    
                }
            }

        }

        private void btnBackupSelect_Click(object sender, EventArgs e)
        {
            using (BackUpEntities _entity = new BackUpEntities())
            {
                int Id = Int32.Parse(lbID.Text);
                var item = _entity.FTPs.SingleOrDefault(p => p.Id == Id);
                if (item.Type == 1)
                    BackupFTP(item);
                if (item.Type == 2)
                    BackupMongodb(item);
                Console.WriteLine("backup successfully: " + item.Name);
                MetroMessageBox.Show(this, "backup successfully: " + item.Name, "Sao lưu", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
            }
           
        }
    }
}


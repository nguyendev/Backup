// See https://aka.ms/new-console-template for more information
using BacklinkFTP;
using System.Net;



    List<FTPInfo> fTPInfos = new List<FTPInfo>();
fTPInfos.Add(new FTPInfo {UserName= "administrator",  Password = "X.aPpw7PpNwVBjC", FolderSave = "H:\\SynologyDrive\\SynologyDrive\\Backups\\Wwwroots\\holidaytshirt", Server = "ftp://38.60.251.19:21" });

foreach (FTPInfo info in fTPInfos)
{

    NetworkCredential credentials = new NetworkCredential(info.UserName, info.Password);
    info.FolderSave = info.FolderSave + "\\" + DateTime.Now.ToString("yyyyMMddhhmm");
    if (!Directory.Exists(info.FolderSave))
    {
        Directory.CreateDirectory(info.FolderSave);
    }

    DownloadFtpDirectory(info.Server + "/wwwroot/assets/images/thumbs", credentials, info.FolderSave, "/");

}
void DownloadFtpDirectory(string url, NetworkCredential credentials, string localPath, string relativePath)
{
    try
    {
        string fullUrl = url.TrimEnd('/') + '/' + relativePath.TrimStart('/');

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
        Thread.Sleep(1000);
        foreach (string line in lines)
        {

            string[] tokens =
                line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[3];
            string permissions = tokens[2];

            string localFilePath = Path.Combine(localPath, name);
            string fileUrl = $"{url}/{name}";

            if (permissions[1] == 'D')
            {
                if (!Directory.Exists(localFilePath))
                {
                    Directory.CreateDirectory(localFilePath);
                }

                DownloadFtpDirectory(fileUrl + "/", credentials, localFilePath, "/");
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
    catch (WebException e)
    {
        String status = ((FtpWebResponse)e.Response).StatusDescription;
    }
}
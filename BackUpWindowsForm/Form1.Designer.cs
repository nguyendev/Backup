namespace BackUpWindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtBoxName = new MetroFramework.Controls.MetroTextBox();
            this.txtFTPServer = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxFolderSave = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxPass = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.lbID = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.txtBoxDatabaseName = new MetroFramework.Controls.MetroTextBox();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.dtStartDT = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbSchedule = new System.Windows.Forms.ComboBox();
            this.btnBackupSelect = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(54, 369);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(846, 237);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(825, 84);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxName
            // 
            // 
            // 
            // 
            this.txtBoxName.CustomButton.Image = null;
            this.txtBoxName.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtBoxName.CustomButton.Name = "";
            this.txtBoxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxName.CustomButton.TabIndex = 1;
            this.txtBoxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxName.CustomButton.UseSelectable = true;
            this.txtBoxName.CustomButton.Visible = false;
            this.txtBoxName.Lines = new string[] {
        "Name"};
            this.txtBoxName.Location = new System.Drawing.Point(131, 84);
            this.txtBoxName.MaxLength = 32767;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.SelectionLength = 0;
            this.txtBoxName.SelectionStart = 0;
            this.txtBoxName.ShortcutsEnabled = true;
            this.txtBoxName.Size = new System.Drawing.Size(252, 23);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.Text = "Name";
            this.txtBoxName.UseSelectable = true;
            this.txtBoxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFTPServer
            // 
            // 
            // 
            // 
            this.txtFTPServer.CustomButton.Image = null;
            this.txtFTPServer.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtFTPServer.CustomButton.Name = "";
            this.txtFTPServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFTPServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFTPServer.CustomButton.TabIndex = 1;
            this.txtFTPServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFTPServer.CustomButton.UseSelectable = true;
            this.txtFTPServer.CustomButton.Visible = false;
            this.txtFTPServer.Lines = new string[] {
        "FTP Server"};
            this.txtFTPServer.Location = new System.Drawing.Point(131, 135);
            this.txtFTPServer.MaxLength = 32767;
            this.txtFTPServer.Name = "txtFTPServer";
            this.txtFTPServer.PasswordChar = '\0';
            this.txtFTPServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFTPServer.SelectedText = "";
            this.txtFTPServer.SelectionLength = 0;
            this.txtFTPServer.SelectionStart = 0;
            this.txtFTPServer.ShortcutsEnabled = true;
            this.txtFTPServer.Size = new System.Drawing.Size(252, 23);
            this.txtFTPServer.TabIndex = 3;
            this.txtFTPServer.Text = "FTP Server";
            this.txtFTPServer.UseSelectable = true;
            this.txtFTPServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFTPServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxFolderSave
            // 
            // 
            // 
            // 
            this.txtBoxFolderSave.CustomButton.Image = null;
            this.txtBoxFolderSave.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.txtBoxFolderSave.CustomButton.Name = "";
            this.txtBoxFolderSave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxFolderSave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFolderSave.CustomButton.TabIndex = 1;
            this.txtBoxFolderSave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFolderSave.CustomButton.UseSelectable = true;
            this.txtBoxFolderSave.CustomButton.Visible = false;
            this.txtBoxFolderSave.Lines = new string[] {
        "Folder Save"};
            this.txtBoxFolderSave.Location = new System.Drawing.Point(131, 187);
            this.txtBoxFolderSave.MaxLength = 32767;
            this.txtBoxFolderSave.Name = "txtBoxFolderSave";
            this.txtBoxFolderSave.PasswordChar = '\0';
            this.txtBoxFolderSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFolderSave.SelectedText = "";
            this.txtBoxFolderSave.SelectionLength = 0;
            this.txtBoxFolderSave.SelectionStart = 0;
            this.txtBoxFolderSave.ShortcutsEnabled = true;
            this.txtBoxFolderSave.Size = new System.Drawing.Size(252, 23);
            this.txtBoxFolderSave.TabIndex = 4;
            this.txtBoxFolderSave.Text = "Folder Save";
            this.txtBoxFolderSave.UseSelectable = true;
            this.txtBoxFolderSave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFolderSave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxUserName
            // 
            // 
            // 
            // 
            this.txtBoxUserName.CustomButton.Image = null;
            this.txtBoxUserName.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtBoxUserName.CustomButton.Name = "";
            this.txtBoxUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxUserName.CustomButton.TabIndex = 1;
            this.txtBoxUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxUserName.CustomButton.UseSelectable = true;
            this.txtBoxUserName.CustomButton.Visible = false;
            this.txtBoxUserName.Lines = new string[] {
        "User name"};
            this.txtBoxUserName.Location = new System.Drawing.Point(528, 87);
            this.txtBoxUserName.MaxLength = 32767;
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.PasswordChar = '\0';
            this.txtBoxUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxUserName.SelectedText = "";
            this.txtBoxUserName.SelectionLength = 0;
            this.txtBoxUserName.SelectionStart = 0;
            this.txtBoxUserName.ShortcutsEnabled = true;
            this.txtBoxUserName.Size = new System.Drawing.Size(272, 23);
            this.txtBoxUserName.TabIndex = 5;
            this.txtBoxUserName.Text = "User name";
            this.txtBoxUserName.UseSelectable = true;
            this.txtBoxUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxPass
            // 
            // 
            // 
            // 
            this.txtBoxPass.CustomButton.Image = null;
            this.txtBoxPass.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtBoxPass.CustomButton.Name = "";
            this.txtBoxPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxPass.CustomButton.TabIndex = 1;
            this.txtBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxPass.CustomButton.UseSelectable = true;
            this.txtBoxPass.CustomButton.Visible = false;
            this.txtBoxPass.Lines = new string[] {
        "Password"};
            this.txtBoxPass.Location = new System.Drawing.Point(528, 135);
            this.txtBoxPass.MaxLength = 32767;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '\0';
            this.txtBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxPass.SelectedText = "";
            this.txtBoxPass.SelectionLength = 0;
            this.txtBoxPass.SelectionStart = 0;
            this.txtBoxPass.ShortcutsEnabled = true;
            this.txtBoxPass.Size = new System.Drawing.Size(272, 23);
            this.txtBoxPass.TabIndex = 6;
            this.txtBoxPass.Text = "Password";
            this.txtBoxPass.UseSelectable = true;
            this.txtBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(825, 135);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(69, 309);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 20);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(825, 187);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(502, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(238, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Backup All";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBoxDatabaseName
            // 
            // 
            // 
            // 
            this.txtBoxDatabaseName.CustomButton.Image = null;
            this.txtBoxDatabaseName.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.txtBoxDatabaseName.CustomButton.Name = "";
            this.txtBoxDatabaseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDatabaseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDatabaseName.CustomButton.TabIndex = 1;
            this.txtBoxDatabaseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDatabaseName.CustomButton.UseSelectable = true;
            this.txtBoxDatabaseName.CustomButton.Visible = false;
            this.txtBoxDatabaseName.Lines = new string[] {
        "DatabaseName"};
            this.txtBoxDatabaseName.Location = new System.Drawing.Point(167, 235);
            this.txtBoxDatabaseName.MaxLength = 32767;
            this.txtBoxDatabaseName.Name = "txtBoxDatabaseName";
            this.txtBoxDatabaseName.PasswordChar = '\0';
            this.txtBoxDatabaseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDatabaseName.SelectedText = "";
            this.txtBoxDatabaseName.SelectionLength = 0;
            this.txtBoxDatabaseName.SelectionStart = 0;
            this.txtBoxDatabaseName.ShortcutsEnabled = true;
            this.txtBoxDatabaseName.Size = new System.Drawing.Size(216, 23);
            this.txtBoxDatabaseName.TabIndex = 12;
            this.txtBoxDatabaseName.Text = "DatabaseName";
            this.txtBoxDatabaseName.UseSelectable = true;
            this.txtBoxDatabaseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDatabaseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cBoxType
            // 
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "FTP",
            "MongoDB"});
            this.cBoxType.Location = new System.Drawing.Point(528, 234);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(272, 24);
            this.cBoxType.TabIndex = 13;
            // 
            // dtStartDT
            // 
            this.dtStartDT.Location = new System.Drawing.Point(131, 273);
            this.dtStartDT.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtStartDT.Name = "dtStartDT";
            this.dtStartDT.Size = new System.Drawing.Size(252, 30);
            this.dtStartDT.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 138);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "FTP Server";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 20);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "Folder Save";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(436, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 20);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "Repeater";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(436, 138);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 20);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Password";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(436, 90);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 20);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "User name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(32, 238);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 20);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Database name";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(436, 238);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(39, 20);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Type";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(32, 283);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(68, 20);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "StartTime";
            // 
            // cbSchedule
            // 
            this.cbSchedule.FormattingEnabled = true;
            this.cbSchedule.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "30",
            "60",
            "120",
            "360",
            "720",
            "2400"});
            this.cbSchedule.Location = new System.Drawing.Point(528, 190);
            this.cbSchedule.Name = "cbSchedule";
            this.cbSchedule.Size = new System.Drawing.Size(272, 24);
            this.cbSchedule.TabIndex = 24;
            // 
            // btnBackupSelect
            // 
            this.btnBackupSelect.Location = new System.Drawing.Point(237, 309);
            this.btnBackupSelect.Name = "btnBackupSelect";
            this.btnBackupSelect.Size = new System.Drawing.Size(238, 23);
            this.btnBackupSelect.TabIndex = 25;
            this.btnBackupSelect.Text = "Backup Select";
            this.btnBackupSelect.UseSelectable = true;
            this.btnBackupSelect.Click += new System.EventHandler(this.btnBackupSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 629);
            this.Controls.Add(this.btnBackupSelect);
            this.Controls.Add(this.cbSchedule);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtStartDT);
            this.Controls.Add(this.cBoxType);
            this.Controls.Add(this.txtBoxDatabaseName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.txtBoxUserName);
            this.Controls.Add(this.txtBoxFolderSave);
            this.Controls.Add(this.txtFTPServer);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Form1";
            this.Text = "Thong tin chi tiet";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtBoxName;
        private MetroFramework.Controls.MetroTextBox txtFTPServer;
        private MetroFramework.Controls.MetroTextBox txtBoxFolderSave;
        private MetroFramework.Controls.MetroTextBox txtBoxUserName;
        private MetroFramework.Controls.MetroTextBox txtBoxPass;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroLabel lbID;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroTextBox txtBoxDatabaseName;
        private System.Windows.Forms.ComboBox cBoxType;
        private MetroFramework.Controls.MetroDateTime dtStartDT;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cbSchedule;
        private MetroFramework.Controls.MetroButton btnBackupSelect;
    }
}


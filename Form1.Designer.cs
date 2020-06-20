namespace TCP_IP_Chat
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_AddSettings = new System.Windows.Forms.TabPage();
            this.label_WANip = new System.Windows.Forms.Label();
            this.label_LANip = new System.Windows.Forms.Label();
            this.label_WANipDescription = new System.Windows.Forms.Label();
            this.label_LANipDescription = new System.Windows.Forms.Label();
            this.label_Connection = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.LB_Port = new System.Windows.Forms.ListBox();
            this.cB_contacts = new System.Windows.Forms.ComboBox();
            this.btn_WaitForConnection = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label_exIP = new System.Windows.Forms.Label();
            this.label_exName = new System.Windows.Forms.Label();
            this.label_AddContact = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_IP = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.tB_IP = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.TP_Chat = new System.Windows.Forms.TabPage();
            this.tB_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tB_Chat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip_Chat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TP_FileTransfer = new System.Windows.Forms.TabPage();
            this.label_ReceiveFile = new System.Windows.Forms.Label();
            this.progressBar_receiveFile = new System.Windows.Forms.ProgressBar();
            this.btn_WaitFile = new System.Windows.Forms.Button();
            this.label_SendFile = new System.Windows.Forms.Label();
            this.progressBar_SendFile = new System.Windows.Forms.ProgressBar();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.TP_remoteDesktop = new System.Windows.Forms.TabPage();
            this.TP_Feedback = new System.Windows.Forms.TabPage();
            this.tB_Log = new System.Windows.Forms.TextBox();
            this.backgroundWorker_Listen = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_connectListen = new System.ComponentModel.BackgroundWorker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.leMultipleClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChatHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog_TBchat = new System.Windows.Forms.FontDialog();
            this.backgroundWorker_SendFile = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_connectSendFile = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_receiveFile = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_connectReceiveFile = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.TP_AddSettings.SuspendLayout();
            this.TP_Chat.SuspendLayout();
            this.contextMenuStrip_Chat.SuspendLayout();
            this.TP_FileTransfer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TP_AddSettings);
            this.tabControl1.Controls.Add(this.TP_Chat);
            this.tabControl1.Controls.Add(this.TP_FileTransfer);
            this.tabControl1.Controls.Add(this.TP_remoteDesktop);
            this.tabControl1.Controls.Add(this.TP_Feedback);
            this.tabControl1.Location = new System.Drawing.Point(-1, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 336);
            this.tabControl1.TabIndex = 0;
            // 
            // TP_AddSettings
            // 
            this.TP_AddSettings.BackColor = System.Drawing.Color.LightGray;
            this.TP_AddSettings.Controls.Add(this.label_WANip);
            this.TP_AddSettings.Controls.Add(this.label_LANip);
            this.TP_AddSettings.Controls.Add(this.label_WANipDescription);
            this.TP_AddSettings.Controls.Add(this.label_LANipDescription);
            this.TP_AddSettings.Controls.Add(this.label_Connection);
            this.TP_AddSettings.Controls.Add(this.btn_Disconnect);
            this.TP_AddSettings.Controls.Add(this.LB_Port);
            this.TP_AddSettings.Controls.Add(this.cB_contacts);
            this.TP_AddSettings.Controls.Add(this.btn_WaitForConnection);
            this.TP_AddSettings.Controls.Add(this.btn_Connect);
            this.TP_AddSettings.Controls.Add(this.label_exIP);
            this.TP_AddSettings.Controls.Add(this.label_exName);
            this.TP_AddSettings.Controls.Add(this.label_AddContact);
            this.TP_AddSettings.Controls.Add(this.btn_Add);
            this.TP_AddSettings.Controls.Add(this.label_IP);
            this.TP_AddSettings.Controls.Add(this.label_Name);
            this.TP_AddSettings.Controls.Add(this.tB_IP);
            this.TP_AddSettings.Controls.Add(this.tB_Name);
            this.TP_AddSettings.Location = new System.Drawing.Point(4, 22);
            this.TP_AddSettings.Name = "TP_AddSettings";
            this.TP_AddSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TP_AddSettings.Size = new System.Drawing.Size(475, 310);
            this.TP_AddSettings.TabIndex = 0;
            this.TP_AddSettings.Text = "Add/Settings";
            // 
            // label_WANip
            // 
            this.label_WANip.AutoSize = true;
            this.label_WANip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WANip.ForeColor = System.Drawing.Color.Red;
            this.label_WANip.Location = new System.Drawing.Point(82, 178);
            this.label_WANip.Name = "label_WANip";
            this.label_WANip.Size = new System.Drawing.Size(16, 15);
            this.label_WANip.TabIndex = 20;
            this.label_WANip.Text = "...";
            // 
            // label_LANip
            // 
            this.label_LANip.AutoSize = true;
            this.label_LANip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LANip.ForeColor = System.Drawing.Color.Red;
            this.label_LANip.Location = new System.Drawing.Point(82, 159);
            this.label_LANip.Name = "label_LANip";
            this.label_LANip.Size = new System.Drawing.Size(16, 15);
            this.label_LANip.TabIndex = 19;
            this.label_LANip.Text = "...";
            // 
            // label_WANipDescription
            // 
            this.label_WANipDescription.AutoSize = true;
            this.label_WANipDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WANipDescription.Location = new System.Drawing.Point(11, 179);
            this.label_WANipDescription.Name = "label_WANipDescription";
            this.label_WANipDescription.Size = new System.Drawing.Size(56, 13);
            this.label_WANipDescription.TabIndex = 18;
            this.label_WANipDescription.Text = "WAN IP:";
            // 
            // label_LANipDescription
            // 
            this.label_LANipDescription.AutoSize = true;
            this.label_LANipDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LANipDescription.Location = new System.Drawing.Point(11, 160);
            this.label_LANipDescription.Name = "label_LANipDescription";
            this.label_LANipDescription.Size = new System.Drawing.Size(51, 13);
            this.label_LANipDescription.TabIndex = 17;
            this.label_LANipDescription.Text = "LAN IP:";
            // 
            // label_Connection
            // 
            this.label_Connection.AutoSize = true;
            this.label_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Connection.Location = new System.Drawing.Point(10, 227);
            this.label_Connection.Name = "label_Connection";
            this.label_Connection.Size = new System.Drawing.Size(100, 20);
            this.label_Connection.TabIndex = 16;
            this.label_Connection.Text = "Connection";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Disconnect.Location = new System.Drawing.Point(3, 283);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(462, 25);
            this.btn_Disconnect.TabIndex = 15;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // LB_Port
            // 
            this.LB_Port.FormattingEnabled = true;
            this.LB_Port.IntegralHeight = false;
            this.LB_Port.Items.AddRange(new object[] {
            "5550",
            "16"});
            this.LB_Port.Location = new System.Drawing.Point(398, 256);
            this.LB_Port.Name = "LB_Port";
            this.LB_Port.Size = new System.Drawing.Size(67, 26);
            this.LB_Port.TabIndex = 14;
            // 
            // cB_contacts
            // 
            this.cB_contacts.DropDownWidth = 500;
            this.cB_contacts.FormattingEnabled = true;
            this.cB_contacts.Location = new System.Drawing.Point(237, 260);
            this.cB_contacts.Name = "cB_contacts";
            this.cB_contacts.Size = new System.Drawing.Size(155, 21);
            this.cB_contacts.TabIndex = 13;
            // 
            // btn_WaitForConnection
            // 
            this.btn_WaitForConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_WaitForConnection.Location = new System.Drawing.Point(112, 259);
            this.btn_WaitForConnection.Name = "btn_WaitForConnection";
            this.btn_WaitForConnection.Size = new System.Drawing.Size(122, 23);
            this.btn_WaitForConnection.TabIndex = 12;
            this.btn_WaitForConnection.Text = "Wait For Connection";
            this.btn_WaitForConnection.UseVisualStyleBackColor = false;
            this.btn_WaitForConnection.Click += new System.EventHandler(this.btn_WaitForConnection_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Connect.Location = new System.Drawing.Point(3, 259);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(108, 23);
            this.btn_Connect.TabIndex = 11;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // label_exIP
            // 
            this.label_exIP.AutoSize = true;
            this.label_exIP.Location = new System.Drawing.Point(342, 77);
            this.label_exIP.Name = "label_exIP";
            this.label_exIP.Size = new System.Drawing.Size(99, 13);
            this.label_exIP.TabIndex = 10;
            this.label_exIP.Text = "ex.   123.456.78.90";
            // 
            // label_exName
            // 
            this.label_exName.AutoSize = true;
            this.label_exName.Location = new System.Drawing.Point(342, 52);
            this.label_exName.Name = "label_exName";
            this.label_exName.Size = new System.Drawing.Size(85, 13);
            this.label_exName.TabIndex = 8;
            this.label_exName.Text = "ex.   Max Muster";
            // 
            // label_AddContact
            // 
            this.label_AddContact.AutoSize = true;
            this.label_AddContact.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddContact.Location = new System.Drawing.Point(10, 7);
            this.label_AddContact.Name = "label_AddContact";
            this.label_AddContact.Size = new System.Drawing.Size(118, 26);
            this.label_AddContact.TabIndex = 7;
            this.label_AddContact.Text = "Add Contact";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(14, 109);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 27);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IP.Location = new System.Drawing.Point(25, 75);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(66, 15);
            this.label_IP.TabIndex = 4;
            this.label_IP.Text = "IP-Address";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(25, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(41, 15);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name";
            // 
            // tB_IP
            // 
            this.tB_IP.Location = new System.Drawing.Point(148, 74);
            this.tB_IP.Name = "tB_IP";
            this.tB_IP.Size = new System.Drawing.Size(183, 20);
            this.tB_IP.TabIndex = 2;
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(148, 47);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(183, 20);
            this.tB_Name.TabIndex = 0;
            // 
            // TP_Chat
            // 
            this.TP_Chat.BackColor = System.Drawing.Color.LightGray;
            this.TP_Chat.Controls.Add(this.tB_Message);
            this.TP_Chat.Controls.Add(this.btn_Send);
            this.TP_Chat.Controls.Add(this.tB_Chat);
            this.TP_Chat.Location = new System.Drawing.Point(4, 22);
            this.TP_Chat.Name = "TP_Chat";
            this.TP_Chat.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Chat.Size = new System.Drawing.Size(475, 310);
            this.TP_Chat.TabIndex = 1;
            this.TP_Chat.Text = "Chat";
            // 
            // tB_Message
            // 
            this.tB_Message.Location = new System.Drawing.Point(3, 173);
            this.tB_Message.Multiline = true;
            this.tB_Message.Name = "tB_Message";
            this.tB_Message.Size = new System.Drawing.Size(470, 75);
            this.tB_Message.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(3, 247);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(470, 62);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tB_Chat
            // 
            this.tB_Chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tB_Chat.ContextMenuStrip = this.contextMenuStrip_Chat;
            this.tB_Chat.Location = new System.Drawing.Point(3, 2);
            this.tB_Chat.Multiline = true;
            this.tB_Chat.Name = "tB_Chat";
            this.tB_Chat.ReadOnly = true;
            this.tB_Chat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_Chat.Size = new System.Drawing.Size(470, 172);
            this.tB_Chat.TabIndex = 0;
            // 
            // contextMenuStrip_Chat
            // 
            this.contextMenuStrip_Chat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.contextMenuStrip_Chat.Name = "contextMenuStrip_Chat";
            this.contextMenuStrip_Chat.Size = new System.Drawing.Size(105, 48);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.fontToolStripMenuItem.Text = "Font..";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // TP_FileTransfer
            // 
            this.TP_FileTransfer.BackColor = System.Drawing.Color.LightGray;
            this.TP_FileTransfer.Controls.Add(this.label_ReceiveFile);
            this.TP_FileTransfer.Controls.Add(this.progressBar_receiveFile);
            this.TP_FileTransfer.Controls.Add(this.btn_WaitFile);
            this.TP_FileTransfer.Controls.Add(this.label_SendFile);
            this.TP_FileTransfer.Controls.Add(this.progressBar_SendFile);
            this.TP_FileTransfer.Controls.Add(this.btn_SendFile);
            this.TP_FileTransfer.Controls.Add(this.btn_Browse);
            this.TP_FileTransfer.Controls.Add(this.TB_FilePath);
            this.TP_FileTransfer.Location = new System.Drawing.Point(4, 22);
            this.TP_FileTransfer.Name = "TP_FileTransfer";
            this.TP_FileTransfer.Size = new System.Drawing.Size(475, 310);
            this.TP_FileTransfer.TabIndex = 2;
            this.TP_FileTransfer.Text = "File Transfer";
            // 
            // label_ReceiveFile
            // 
            this.label_ReceiveFile.AutoSize = true;
            this.label_ReceiveFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_ReceiveFile.Location = new System.Drawing.Point(161, 156);
            this.label_ReceiveFile.Name = "label_ReceiveFile";
            this.label_ReceiveFile.Size = new System.Drawing.Size(16, 13);
            this.label_ReceiveFile.TabIndex = 7;
            this.label_ReceiveFile.Text = "...";
            // 
            // progressBar_receiveFile
            // 
            this.progressBar_receiveFile.Location = new System.Drawing.Point(164, 179);
            this.progressBar_receiveFile.Name = "progressBar_receiveFile";
            this.progressBar_receiveFile.Size = new System.Drawing.Size(301, 27);
            this.progressBar_receiveFile.TabIndex = 6;
            // 
            // btn_WaitFile
            // 
            this.btn_WaitFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_WaitFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WaitFile.Location = new System.Drawing.Point(12, 156);
            this.btn_WaitFile.Name = "btn_WaitFile";
            this.btn_WaitFile.Size = new System.Drawing.Size(146, 50);
            this.btn_WaitFile.TabIndex = 5;
            this.btn_WaitFile.Text = "Wait for File";
            this.btn_WaitFile.UseVisualStyleBackColor = false;
            this.btn_WaitFile.Click += new System.EventHandler(this.btn_WaitFile_Click);
            // 
            // label_SendFile
            // 
            this.label_SendFile.AutoSize = true;
            this.label_SendFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_SendFile.Location = new System.Drawing.Point(161, 46);
            this.label_SendFile.Name = "label_SendFile";
            this.label_SendFile.Size = new System.Drawing.Size(16, 13);
            this.label_SendFile.TabIndex = 4;
            this.label_SendFile.Text = "...";
            // 
            // progressBar_SendFile
            // 
            this.progressBar_SendFile.Location = new System.Drawing.Point(164, 69);
            this.progressBar_SendFile.Name = "progressBar_SendFile";
            this.progressBar_SendFile.Size = new System.Drawing.Size(301, 27);
            this.progressBar_SendFile.TabIndex = 3;
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_SendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendFile.Location = new System.Drawing.Point(9, 46);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(149, 50);
            this.btn_SendFile.TabIndex = 2;
            this.btn_SendFile.Text = "Send File";
            this.btn_SendFile.UseVisualStyleBackColor = false;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(398, 18);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(67, 23);
            this.btn_Browse.TabIndex = 1;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // TB_FilePath
            // 
            this.TB_FilePath.Location = new System.Drawing.Point(9, 20);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.Size = new System.Drawing.Size(383, 20);
            this.TB_FilePath.TabIndex = 0;
            // 
            // TP_remoteDesktop
            // 
            this.TP_remoteDesktop.BackColor = System.Drawing.Color.LightGray;
            this.TP_remoteDesktop.Location = new System.Drawing.Point(4, 22);
            this.TP_remoteDesktop.Name = "TP_remoteDesktop";
            this.TP_remoteDesktop.Size = new System.Drawing.Size(475, 310);
            this.TP_remoteDesktop.TabIndex = 3;
            this.TP_remoteDesktop.Text = "Remote Desktop";
            // 
            // TP_Feedback
            // 
            this.TP_Feedback.BackColor = System.Drawing.Color.LightGray;
            this.TP_Feedback.Location = new System.Drawing.Point(4, 22);
            this.TP_Feedback.Name = "TP_Feedback";
            this.TP_Feedback.Size = new System.Drawing.Size(475, 310);
            this.TP_Feedback.TabIndex = 4;
            this.TP_Feedback.Text = "Feedback";
            // 
            // tB_Log
            // 
            this.tB_Log.Location = new System.Drawing.Point(2, 359);
            this.tB_Log.Multiline = true;
            this.tB_Log.Name = "tB_Log";
            this.tB_Log.ReadOnly = true;
            this.tB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_Log.Size = new System.Drawing.Size(480, 169);
            this.tB_Log.TabIndex = 1;
            // 
            // backgroundWorker_Listen
            // 
            this.backgroundWorker_Listen.WorkerSupportsCancellation = true;
            this.backgroundWorker_Listen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Listen_DoWork);
            // 
            // backgroundWorker_connectListen
            // 
            this.backgroundWorker_connectListen.WorkerSupportsCancellation = true;
            this.backgroundWorker_connectListen.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_connectListen_DoWork);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leMultipleClientToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(480, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // leMultipleClientToolStripMenuItem
            // 
            this.leMultipleClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.saveChatHistoryToolStripMenuItem,
            this.saveLogToolStripMenuItem,
            this.informationInstructionsToolStripMenuItem,
            this.updateInformationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.leMultipleClientToolStripMenuItem.Name = "leMultipleClientToolStripMenuItem";
            this.leMultipleClientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.leMultipleClientToolStripMenuItem.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveChatHistoryToolStripMenuItem
            // 
            this.saveChatHistoryToolStripMenuItem.Name = "saveChatHistoryToolStripMenuItem";
            this.saveChatHistoryToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveChatHistoryToolStripMenuItem.Text = "Save Chat History..";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveLogToolStripMenuItem.Text = "Save Log..";
            // 
            // informationInstructionsToolStripMenuItem
            // 
            this.informationInstructionsToolStripMenuItem.Name = "informationInstructionsToolStripMenuItem";
            this.informationInstructionsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.informationInstructionsToolStripMenuItem.Text = "Informations/Instructions";
            // 
            // updateInformationsToolStripMenuItem
            // 
            this.updateInformationsToolStripMenuItem.Name = "updateInformationsToolStripMenuItem";
            this.updateInformationsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.updateInformationsToolStripMenuItem.Text = "Update Informations";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fontDialog_TBchat
            // 
            this.fontDialog_TBchat.AllowVerticalFonts = false;
            this.fontDialog_TBchat.MaxSize = 30;
            this.fontDialog_TBchat.MinSize = 5;
            // 
            // backgroundWorker_SendFile
            // 
            this.backgroundWorker_SendFile.WorkerSupportsCancellation = true;
            this.backgroundWorker_SendFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_SendFile_DoWork);
            // 
            // backgroundWorker_connectSendFile
            // 
            this.backgroundWorker_connectSendFile.WorkerSupportsCancellation = true;
            this.backgroundWorker_connectSendFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_connectSendFile_DoWork);
            // 
            // backgroundWorker_receiveFile
            // 
            this.backgroundWorker_receiveFile.WorkerSupportsCancellation = true;
            this.backgroundWorker_receiveFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_receiveFile_DoWork);
            // 
            // backgroundWorker_connectReceiveFile
            // 
            this.backgroundWorker_connectReceiveFile.WorkerSupportsCancellation = true;
            this.backgroundWorker_connectReceiveFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_connectReceiveFile_DoWork);
            // 
            // Form_Main
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 527);
            this.Controls.Add(this.tB_Log);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Le Multifunctional Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TP_AddSettings.ResumeLayout(false);
            this.TP_AddSettings.PerformLayout();
            this.TP_Chat.ResumeLayout(false);
            this.TP_Chat.PerformLayout();
            this.contextMenuStrip_Chat.ResumeLayout(false);
            this.TP_FileTransfer.ResumeLayout(false);
            this.TP_FileTransfer.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_AddSettings;
        private System.Windows.Forms.TabPage TP_Chat;
        private System.Windows.Forms.Label label_AddContact;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox tB_IP;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_Log;
        private System.Windows.Forms.TextBox tB_Chat;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Label label_exIP;
        private System.Windows.Forms.Label label_exName;
        private System.Windows.Forms.TextBox tB_Message;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Listen;
        private System.ComponentModel.BackgroundWorker backgroundWorker_connectListen;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.ListBox LB_Port;
        private System.Windows.Forms.ComboBox cB_contacts;
        private System.Windows.Forms.Button btn_WaitForConnection;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label_Connection;
        private System.Windows.Forms.Label label_WANip;
        private System.Windows.Forms.Label label_LANip;
        private System.Windows.Forms.Label label_WANipDescription;
        private System.Windows.Forms.Label label_LANipDescription;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem leMultipleClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage TP_FileTransfer;
        private System.Windows.Forms.Label label_ReceiveFile;
        private System.Windows.Forms.ProgressBar progressBar_receiveFile;
        private System.Windows.Forms.Button btn_WaitFile;
        private System.Windows.Forms.Label label_SendFile;
        private System.Windows.Forms.ProgressBar progressBar_SendFile;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.TabPage TP_remoteDesktop;
        private System.Windows.Forms.TabPage TP_Feedback;
        private System.Windows.Forms.ToolStripMenuItem saveChatHistoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Chat;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog_TBchat;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker_SendFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker_connectSendFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker_receiveFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker_connectReceiveFile;
    }
}


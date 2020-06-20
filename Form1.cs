using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TCP_IP_Chat
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        
        int port = 0;
        int mInQueue = 0;
        string disconnect = "";
        string stringException;
        string receivedMessage;
        string endPointIP;
        string messageInQueue;
        string WaitOrConnect;
        string connectReceivedMessage;
        string disconnectBWconnect = "";
        
        //FileToSend
        string FilePath;
        string FileToSend;
        byte[] DataToSend;

        protected delegate void setTextMethodDelegate();
        TcpClient clientConnect = new TcpClient();
        TcpClient Client = new TcpClient();

        public void WaitingForConnection()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Waiting for connection...";
            tB_Log.Refresh();
        }

        public void ConnectedTo()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Connected to  " + endPointIP;
            tB_Log.Refresh();
        }

        public void PartnerDisconnected()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Chat-Partner or you has disconnected." + Environment.NewLine + "Connection closed.";
            tB_Log.Refresh();
        }

        public void TextTransmission()
        {
            tB_Chat.Text = tB_Chat.Text + Environment.NewLine + endPointIP + ":  " + receivedMessage;
            tB_Chat.Refresh();
        }

        public void connectTextTransmission()
        {
            tB_Chat.Text = tB_Chat.Text + Environment.NewLine + endPointIP + ":  " + connectReceivedMessage;
            tB_Chat.Refresh();
        }

        public void bw_catch()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Error:" + Environment.NewLine + stringException;
            tB_Log.Refresh();
        }

        public void bw_catchSendFile()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Error:" + Environment.NewLine + stringException;
            tB_Log.Refresh();
            label_SendFile.Text = "Error.";
            label_SendFile.Refresh();
        }

        public void bw_catchReceiveFile()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Error:" + Environment.NewLine + stringException;
            tB_Log.Refresh();
            label_ReceiveFile.Text = "Error.";
            label_ReceiveFile.Refresh();
        }

        public void SendFileCompleted()
        {
            label_SendFile.Text = "Completed.";
            label_SendFile.Refresh();
        }

        public void ReceiveFileCompleted()
        {
            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Saved File to:  " + @"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Received Files";
            tB_Log.Refresh();
            label_ReceiveFile.Text = "Completed.";
            label_ReceiveFile.Refresh();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string newcontact = tB_Name.Text + Environment.NewLine + tB_IP.Text;
            if (Directory.Exists(@"C:\Users\Admin\AppData\Roaming\.LeChat\Contacts"))
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Admin\AppData\Roaming\.LeChat\Contacts\" + tB_Name.Text + ".txt");
                file.WriteLine(newcontact);
                file.Close();
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "Contact successfully added.";
            }
            else
            {
                Directory.CreateDirectory(@"C:\Users\Admin\AppData\Roaming\.LeChat");
                System.Threading.Thread.Sleep(500);
                Directory.CreateDirectory(@"C:\Users\Admin\AppData\Roaming\.LeChat\Contacts");
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "Directory successfully created: " + @"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Contacts";
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Admin\AppData\Roaming\.LeChat\Contacts\" + tB_Name.Text + ".txt");
                file.WriteLine(newcontact);
                file.Close();
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "Contact successfully added.";
            }
            cB_contacts.Items.AddRange(Directory.GetFiles(@"C:\Users\Admin\AppData\Roaming\.LeChat\Contacts"));
        }

        private void backgroundWorker_Listen_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_Listen.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        TcpListener Server = new TcpListener(port);
                        Server.Start();
                        tB_Log.Invoke(new setTextMethodDelegate(WaitingForConnection));

                        disconnect = "connecting";

                        Client = Server.AcceptTcpClient();

                        Stream MessageStream = Client.GetStream();
                        ASCIIEncoding encoder = new ASCIIEncoding();

                        if (Client.Connected == true)
                        {
                            endPointIP = Client.Client.RemoteEndPoint.ToString();
                            tB_Log.Invoke(new setTextMethodDelegate(ConnectedTo));
                            disconnect = "connected";
                            WaitOrConnect = "wait";
                        }

                        while (true)
                        {
                            if (Client.Connected == true)
                            {
                                byte[] message = new byte[4096];
                                int bytesRead;
                                bytesRead = MessageStream.Read(message, 0, 4096);

                                if (bytesRead == 0)
                                {
                                    tB_Log.Invoke(new setTextMethodDelegate(PartnerDisconnected));
                                    // Client beendet
                                    break;
                                }

                                if (mInQueue == 1)
                                {
                                    byte[] buffer = encoder.GetBytes(messageInQueue);

                                    MessageStream.Write(buffer, 0, buffer.Length);
                                    MessageStream.Flush();
                                    mInQueue = 0;
                                }

                                receivedMessage = encoder.GetString(message, 0, bytesRead);
                                tB_Chat.Invoke(new setTextMethodDelegate(TextTransmission));
                            }
                            else
                            {
                                tB_Log.Invoke(new setTextMethodDelegate(PartnerDisconnected));
                                // Client beendet
                                break;
                            }
                        }

                        if (Client.Connected == true)
                        {
                            Client.GetStream().Close();
                            Client.Close();
                            Server.Stop();
                            return;
                        }

                    }
                 }
            }

            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catch));
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (WaitOrConnect == "wait")
            {
                if (Client.Connected == true)
                {
                    Stream MessageStream = Client.GetStream();
                    ASCIIEncoding encoder = new ASCIIEncoding();

                    byte[] buffer = encoder.GetBytes(tB_Message.Text);

                    MessageStream.Write(buffer, 0, buffer.Length);
                    MessageStream.Flush();

                    tB_Chat.Text = tB_Chat.Text + Environment.NewLine + "You:  " + tB_Message.Text;
                    tB_Message.Clear();

                    /*messageInQueue = tB_Message.Text;
                    mInQueue = 1;
                    tB_Chat.Text = tB_Chat.Text + Environment.NewLine + messageInQueue;*/
                }
            }
            else if (WaitOrConnect == "connect")
            {
                if (clientConnect.Connected == true)
                {
                    Stream MessageStream = clientConnect.GetStream();
                    ASCIIEncoding encoder = new ASCIIEncoding();

                    byte[] buffer = encoder.GetBytes(tB_Message.Text);

                    MessageStream.Write(buffer, 0, buffer.Length);
                    MessageStream.Flush();

                    tB_Chat.Text = tB_Chat.Text + Environment.NewLine + "You:  " + tB_Message.Text;
                    tB_Message.Clear();
                }
            }
            else
            {
                MessageBox.Show("Client has to be connected first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Message.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (Directory.Exists(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Contacts"))
            {
                cB_contacts.Items.AddRange(Directory.GetFiles(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Contacts"));
                cB_contacts.Refresh();
            }
            if (Directory.Exists(@"C:\Users\Admin\AppData\Roaming\.LeChat") == false)
            {
                Directory.CreateDirectory(@"C:\Users\Admin\AppData\Roaming\.LeChat");
            }
            if (Directory.Exists(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Received Files") == false)
            {
                Directory.CreateDirectory(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Received Files");
            }
            try
            {
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                        break;
                    }
                }
                label_LANip.Text = localIP;
            }
            catch{ }

            try
            {
                string url = "http://checkip.dyndns.org";
                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                string response = sr.ReadToEnd().Trim();
                string[] a = response.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                string a4 = a3[0];
                label_WANip.Text = a4;
            }
            catch 
            {
                label_WANip.Text = "-";
            }

            Cursor = Cursors.Default;

        }

        private void backgroundWorker_connectListen_DoWork(object sender, DoWorkEventArgs e)
        {
             try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_Listen.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {

                        Stream messageStream = clientConnect.GetStream();
                        ASCIIEncoding encoder = new ASCIIEncoding();

                        if (clientConnect.Connected == true)
                        {
                            endPointIP = clientConnect.Client.RemoteEndPoint.ToString();
                        }

                        while (true)
                        {
                            if (clientConnect.Connected == true)
                            {
                                byte[] message = new byte[4096];
                                int bytesRead;
                                bytesRead = messageStream.Read(message, 0, 4096);

                                if (bytesRead == 0)
                                {
                                     tB_Log.Invoke(new setTextMethodDelegate(PartnerDisconnected));
                                     break;
                                }

                                connectReceivedMessage = encoder.GetString(message, 0, bytesRead);
                                tB_Chat.Invoke(new setTextMethodDelegate(connectTextTransmission));

                                }
                                else
                                {
                                    tB_Log.Invoke(new setTextMethodDelegate(PartnerDisconnected));
                                    // Client beendet
                                    break;
                                }
                        }

                        if (clientConnect.Connected == true)
                        {
                            clientConnect.GetStream().Close();
                            clientConnect.Close();
                            return;
                        }
                    }
                 }
            }

            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catch));
            }

            }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientConnect.Connected == false && (disconnect != "connecting" || disconnect != "connected"))
                {
                    if (LB_Port.SelectedItem != null && cB_contacts.SelectedItem != null)
                    {
                        string Port;
                        Port = LB_Port.SelectedItem.ToString();
                        port = Int32.Parse(Port);

                        string line = "";
                        string path = cB_contacts.SelectedItem.ToString();
                        StreamReader sr = new StreamReader(@path);
                        if (sr.ReadLine() != null)
                        {
                            line = sr.ReadLine();
                        }

                        System.Net.IPAddress IP = System.Net.IPAddress.Parse(line);

                        try
                        {
                            clientConnect.Connect(IP, port);
                        }
                        catch
                        {
                            clientConnect.Close();
                            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Couldn't connect to  " + IP;
                            return;
                        }

                        if (clientConnect.Connected == true)
                        {
                            backgroundWorker_connectListen.RunWorkerAsync();
                            tB_Log.Text = tB_Log.Text + Environment.NewLine + "Connected to  " + IP;
                            WaitOrConnect = "connect";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please select a contact AND a port first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Client is already connected!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "No connection could be made. Try to restart the application.";
            }
        }

        private void btn_WaitForConnection_Click(object sender, EventArgs e)
        {
            if (backgroundWorker_Listen.IsBusy)
            {
                MessageBox.Show("LeChat is already waiting for a connection!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Port;

                if (LB_Port.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a port first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Port = LB_Port.SelectedItem.ToString();
                    port = Int32.Parse(Port);
                    backgroundWorker_Listen.RunWorkerAsync();

                }
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (disconnect == "connecting" && backgroundWorker_Listen.IsBusy)
            {
                MessageBox.Show("You can't disconnect while LeChat is waiting for a connection!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (disconnect == "connected")
            {
                Client.GetStream().Close();
                Client.Close();
                backgroundWorker_Listen.CancelAsync();
                Application.DoEvents();
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "Disconnected.";
                tB_Log.Refresh();
            }
            else if (WaitOrConnect == "connect")
            {
                clientConnect.GetStream().Close();
                clientConnect.Close();
                backgroundWorker_connectListen.CancelAsync();
                Application.DoEvents();
                tB_Log.Text = tB_Log.Text + Environment.NewLine + "Disconnected.";
                tB_Log.Refresh();
                WaitOrConnect = "";
            }
            else
            {
                MessageBox.Show("Client has to be connected first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog_TBchat.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = fontDialog_TBchat.Font;
                tB_Chat.Font = font;
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_Chat.BackColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_Chat.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_Chat.BackColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_Chat.BackColor = Color.Yellow;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tB_Chat.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Filter = "";
            FileDialog.InitialDirectory = "";
            FileDialog.Title = "Select a File";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                TB_FilePath.Text = FileDialog.FileName;
            }
        }

        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(TB_FilePath.Text))
            {
                if (clientConnect.Connected == true)
                {
                    FilePath = tB_Chat.Text;
                    label_SendFile.Text = "Sending Data...";
                    label_SendFile.Refresh();
                    backgroundWorker_connectSendFile.RunWorkerAsync();

                }
                if (Client.Connected == true)
                {
                    FilePath = tB_Chat.Text;
                    label_SendFile.Text = "Sending Data...";
                    label_SendFile.Refresh();
                    backgroundWorker_SendFile.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Client has to be connected first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("File does not exist!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_WaitFile_Click(object sender, EventArgs e)
        {
            if (clientConnect.Connected == true)
            {
                label_ReceiveFile.Text = "Receiving Data...";
                label_ReceiveFile.Refresh();
                backgroundWorker_connectReceiveFile.RunWorkerAsync();
            }
            if (Client.Connected == true)
            {
                label_ReceiveFile.Text = "Receiving Data...";
                label_ReceiveFile.Refresh();
                backgroundWorker_receiveFile.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Client has to be connected first!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker_connectSendFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_connectSendFile.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        Stream fileStream = clientConnect.GetStream();
                        DataToSend = File.ReadAllBytes(FilePath);
                        fileStream.Write(DataToSend, 0, DataToSend.Length);
                        fileStream.Flush();
                        fileStream.Dispose();
                        fileStream.Close();
                        label_SendFile.Invoke(new setTextMethodDelegate(SendFileCompleted));
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catchSendFile));
            }
        }

        private void backgroundWorker_SendFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_SendFile.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        Stream fileStream = Client.GetStream();
                        DataToSend = File.ReadAllBytes(FilePath);
                        fileStream.Write(DataToSend, 0, DataToSend.Length);
                        fileStream.Flush();
                        fileStream.Dispose();
                        fileStream.Close();
                        label_SendFile.Invoke(new setTextMethodDelegate(SendFileCompleted));
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catchSendFile));
            }
        }

        private void backgroundWorker_connectReceiveFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_connectReceiveFile.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        using (NetworkStream networkStream = clientConnect.GetStream())
                        {
                            using (Stream stream = new FileStream(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Received Files", FileMode.Create, FileAccess.ReadWrite))
                            {
                                // Buffer for reading data
                                Byte[] bytes = new Byte[1024];

                                int length;

                                while ((length = networkStream.Read(bytes, 0, bytes.Length)) != 0)
                                {
                                    stream.Write(bytes, 0, length);
                                }
                                stream.Dispose();
                                stream.Close();
                            }
                            networkStream.Dispose();
                            networkStream.Close();
                        }                   
                        label_ReceiveFile.Invoke(new setTextMethodDelegate(ReceiveFileCompleted));
                    }
                }
            }
            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catchReceiveFile));
            }
        }

        private void backgroundWorker_receiveFile_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; (i < 1); i = 0)
                {
                    if (backgroundWorker_receiveFile.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        using (NetworkStream networkStream = Client.GetStream())
                        {
                            using (Stream stream = new FileStream(@"C:\Users\Admin\AppData\Roaming\.LeChat" + "\\Received Files", FileMode.Create, FileAccess.ReadWrite))
                            {
                                // Buffer for reading data
                                Byte[] bytes = new Byte[1024];

                                int length;

                                while ((length = networkStream.Read(bytes, 0, bytes.Length)) != 0)
                                {
                                    stream.Write(bytes, 0, length);
                                }
                                stream.Dispose();
                                stream.Close();
                            }
                            networkStream.Dispose();
                            networkStream.Close();
                        }
                        label_ReceiveFile.Invoke(new setTextMethodDelegate(ReceiveFileCompleted));
                    }
                }
            }
            catch (Exception ex)
            {
                stringException = ex.ToString();
                tB_Log.Invoke(new setTextMethodDelegate(bw_catchReceiveFile));
            }
        }
        }
    }

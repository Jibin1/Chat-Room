using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ChatRoomClient
{
    public partial class ChatWindow : Form
    {

        public TcpClient client;

        public StreamWriter sw;

        public StreamReader sr;

        private bool connected;

        public List<Message> messageList;

        public string currentUser;

        public ChatWindow()
        {
            InitializeComponent();
            connected = false;
            messageList = new List<Message>();
            currentUser = null;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (connected == false)
            {
                try
                {
                    client = new TcpClient("127.0.0.1", 55555);
                    sw = new StreamWriter(client.GetStream());
                    sr = new StreamReader(client.GetStream());
                    ConnectButton.Text = "Disconnect";

                    Thread readThread = new Thread(receive);
                    readThread.Start();
                    //ChatRichTextBox.Text = "What is your name?";

                   
                    connected = true;                    
                }
                catch
                {
                    Console.WriteLine("failed to connect");
                }
            }
            else
            {
                client.Close();
                connected = false;
                ConnectButton.Text = "Connect";
            }
        }

        public void receive()
        {
            while (true)
            {
                try
                {
                    
                    string response = sr.ReadLine();
                    Console.WriteLine(response);
                  
                    string userName = response.Substring(0, response.IndexOf(':'));
                    string message = response.Substring(response.IndexOf(':') + 1);
                    //Console.WriteLine("userName: " + userName + " ,message: " + message);
                    Message newMessage = new Message(userName, message);
                    messageList.Add(newMessage);
                    ChatRichTextBox.AppendText(response + " \n");
                    
                    
                }
                catch
                {

                }
            }

        }


        private void SendButton_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {


                if (currentUser == null)
                {
                    currentUser = UserTextBox.Text;
                    sw.WriteLine(currentUser);
                }
                else
                {
                    try
                    {
                        string message = UserTextBox.Text;
                        Message newMessage = new Message(currentUser, message);
                        messageList.Add(newMessage);
                        sw.WriteLine(currentUser + ": " + message);
                    }
                    catch
                    {
                        ChatRichTextBox.AppendText("Failed to deliver message \n");
                    }
                }
                sw.Flush();
                UserTextBox.Clear();
            }else
            {
                MessageBox.Show("Not connected to server.");
                
            }
        }

        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("The key code is " + e.KeyCode.ToString() + " the keydata is " + e.KeyData.ToString() );
            if(e.KeyData == Keys.Return)
            {
                SendButton_Click(sender, e);
            }
        }
    }
}

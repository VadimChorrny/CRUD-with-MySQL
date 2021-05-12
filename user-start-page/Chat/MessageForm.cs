using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_start_page.Chat
{
    public partial class MessageForm : Form
    {
        bool alive = false; 
        UdpClient client;
        const int LOCALPORT = 8001; // port for give message
        const int REMOTEPORT = 8001; // port for take message
        const int TTL = 20;
        const string HOST = "235.5.5.1";
        IPAddress groupAddress;
        string userName;

        public MessageForm()
        {
            InitializeComponent();
            btnJoin.Enabled = true; 
            btnExit.Enabled = false; 
            btnSend.Enabled = false; 
            tbChat.ReadOnly = true; 
            groupAddress = IPAddress.Parse(HOST);
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            userName = tbUserName.Text;
            tbUserName.ReadOnly = true;

            try
            {
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " (user) join in chat!";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                btnJoin.Enabled = false;
                btnExit.Enabled = true;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        tbChat.Text = time + " " + message + "\r\n" + tbChat.Text;
                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName, tbMessage.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);
                tbMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        private void ExitChat()
        {
            string message = userName + " (user) leave chat";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);

            alive = false;
            client.Close();

            btnJoin.Enabled = true;
            btnExit.Enabled = false;
            btnSend.Enabled = false;
            //tbUserName.ReadOnly = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
    }
}

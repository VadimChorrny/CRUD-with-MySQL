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

namespace ChatUDP
{
    public partial class Form1 : Form
    {

        #region properties
        bool alive = false; // for check stream
        UdpClient client;
        const int LOCALPORT = 8001; // port for give message
        const int REMOTEPORT = 8001; // port for take message
        const int TTL = 20;
        const string HOST = "235.5.5.1"; // host for we can send message all
        IPAddress groupAddress;
        string userName; // name user in chat
        #endregion

        public Form1()
        {
            InitializeComponent();
            btnLogout.Enabled = false;
            btnSignIn.Enabled = true;
            btnSend.Enabled = false;
            tbChat.ReadOnly = true;
            groupAddress = IPAddress.Parse(HOST);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            userName = tbUserName.Text;
            tbUserName.ReadOnly = true;
            try
            {
                client = new UdpClient(LOCALPORT);
                client.JoinMulticastGroup(groupAddress, TTL);
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                string message = userName + " join to chat";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, HOST, REMOTEPORT);

                btnSignIn.Enabled = false;
                btnLogout.Enabled = true;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ExitChat()
        {
            string message = userName + " покидает чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, HOST, REMOTEPORT);
            client.DropMulticastGroup(groupAddress);

            alive = false;
            client.Close();

            btnSignIn.Enabled = true;
            btnLogout.Enabled = false;
            btnSend.Enabled = false;
            tbUserName.ReadOnly = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
    }
}

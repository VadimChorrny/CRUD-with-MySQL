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
        #region properties
        bool alive = false;
        UdpClient client;
        const int LOCALPORT = 8001;
        const int REMOTEPORT = 8001;
        const int TTL = 20;
        const string HOST = "235.5.5.1";
        IPAddress groupAddress;
        string userName;
        #endregion
        public MessageForm()
        {
            InitializeComponent();

            // START INIT
            picJoin.Enabled = true;
            picClose.Enabled = false;
            picSend.Enabled = false;
            tbChat.ReadOnly = true;
            groupAddress = IPAddress.Parse(HOST);

        }
        #region work_with_udp
        private void picJoin_Click(object sender, EventArgs e)
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

                picJoin.Enabled = false;
                picClose.Enabled = true;
                picSend.Enabled = true;
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
        private void picSend_Click(object sender, EventArgs e)
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
        private void picClose_Click(object sender, EventArgs e)
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

            picJoin.Enabled = true;
            picClose.Enabled = false;
            picSend.Enabled = false;
            //tbUserName.ReadOnly = false;
        }
        private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
        #endregion

    }
}

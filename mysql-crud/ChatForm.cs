using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace mysql_crud
{
    public partial class ChatForm : Form
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
        public ChatForm()
        {
            InitializeComponent();

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
                // присоединяемся к групповой рассылке
                client.JoinMulticastGroup(groupAddress, TTL);

                // запускаем задачу на прием сообщений
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                // отправляем первое сообщение о входе нового пользователя
                string message = userName + " join in chat!";
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

                    // добавляем полученное сообщение в текстовое поле
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
            string message = userName + " leave chat";
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
        #endregion
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
    }
}
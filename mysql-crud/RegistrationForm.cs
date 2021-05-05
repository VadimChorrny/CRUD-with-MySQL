using MySql.Data.MySqlClient;
using mysql_crud.myclass;
using mysql_crud.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_crud
{
    public partial class RegistrationForm : Form
    {

        private CRUD crud;
        private User user;

        public RegistrationForm()
        {
            InitializeComponent();
            //var fileDir = AppDomain.CurrentDomain.BaseDirectory;
            //fileName = Path.Combine(fileDir, "user.bin"); // get name file
            //if (File.Exists(fileName))
            //    using (var fs = File.OpenRead(fileName))
            //        users = (Users)new BinaryFormatter().Deserialize(fs);
            //else
            //    users = new Users();
        }

        private  void AddUserDataToDb()
        {
            MySqlConnection con;
            string host = "localhost";
            string db = "product";
            string port = "3306";
            string user = "root"; // maybe changed
            string pass = ""; // maybe changed
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + ";username =" + user + "; password =" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            if (isUserExists())
            {
                return;
            }
            else
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO users (`Login`, `Password`) VALUES (@login,@password)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbLogin.Text;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = tbPassword.Text;
                    if (cmd.ExecuteNonQuery() == 1)
                        MessageBox.Show("Account has been created!");
                    else
                        MessageBox.Show("Account doesn't created!");
                    con.Close();
                }
            }


        }

        private Boolean isUserExists()
        {
            MySqlConnection con;
            string host = "localhost";
            string db = "product";
            string port = "3306";
            string user = "root"; // maybe changed
            string pass = ""; // maybe changed
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + ";username =" + user + "; password =" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL",con);
            cmd.Parameters.Add("@uL",MySqlDbType.VarChar).Value = tbLogin.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Account is exist!");
                return true;
            }
            else
                return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserDataToDb();

        }
    }
}

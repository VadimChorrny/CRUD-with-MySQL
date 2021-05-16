using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_crud
{
    public partial class EditAccount : Form
    {
        #region properties
        RegistrationForm rf = new RegistrationForm();
        #endregion
        public EditAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetRegData();
        }
        /// <summary>
        /// function for change login and password
        /// </summary>
        public void SetRegData()
        {
            MySqlConnection con;
            string host = "localhost";
            string db = "product";
            string port = "3306";
            string user = "root"; // maybe changed
            string pass = ""; // maybe changed
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + ";username =" + user + "; password =" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE `users` SET ID=@id,Login=@login,Password=@password WHERE ID =" + rf.id;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtLogin.Text;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPass.Text;

                cmd.CommandText = "SELECT * FROM `users` WHERE ID = @id";

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = rf.id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

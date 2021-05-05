using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_crud.user
{
    class DB
    {
        public MySqlConnection con;
        public DB()
        {
            string host = "localhost";
            string db = "product";
            string port = "3306";
            string user = "root"; // maybe changed
            string pass = ""; // maybe changed
            string constring = "datasource =" + host + "; database =" + db + "; port =" + port + ";username =" + user + "; password =" + pass + "; SslMode=none";
            con = new MySqlConnection(constring);
        }
    }

    class User : DB
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int id { get; set; } = new Random().Next(10000, 100000);
        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // CREATE FUNCTION
        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `users`(`ID`, `Login`, `Password`) VALUES (@id,@login,@password)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // UPDATE FUNCTION
        public void Update_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE `users` SET Login = @login, Password = @password WHERE ID = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}

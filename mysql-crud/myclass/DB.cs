using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace mysql_crud.myclass
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

    class CRUD : DB
    {
        // PROPERTIES
        public string name { get; set; }
        public string describe { get; set; }
        public string price { get; set; }
        public string fullname { get; set; }

        // FOR ID
        public string id { set; get; }

        // FOR IMAGE
        public string str { get; set; }

        // FOR SEARCH
        UserMenu userMenu;

        // READ PROPERTIES
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        // CREATE FUNCTION
        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `products`(`Name`, `Describes`, `Price`,`Fullname`,`Image`) VALUES (@name,@desc,@price,@fullname,@image)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = describe;
                cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname;
                cmd.Parameters.Add("@image", MySqlDbType.Blob).Value = str;
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
                cmd.CommandText = "UPDATE products SET Name = @name, Describes = @desc, Price = @price, Fullname = @fullname,Image = @image WHERE ID = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = describe;
                cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname;
                cmd.Parameters.Add("@image", MySqlDbType.Blob).Value = str;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // DELETE FUNCTION
        public void Delete_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM products WHERE ID=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        // READ FUNCTION
        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `products`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }

        // SEARCH FUNCTION
        public void Search_data()
        {
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = $"SELECT `ID`, `Name`, `Describes`, `Price`, `Fullname` FROM `products` WHERE ID = " + userMenu.txtSearch.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Please complete correct the fields");
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Clone();
            }
        }
    }
}

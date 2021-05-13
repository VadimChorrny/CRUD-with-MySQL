using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using user_start_page.Chat;

namespace user_start_page
{

    public partial class UserMenu : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=product;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;
        DataTable dt;

        public UserMenu()
        {
            InitializeComponent();

        }

        // OPEN CHAT
        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm mf = new MessageForm();
            mf.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            #region comment
            //string pass = "";
            //string connStr = "server=localhost;user=root;database=product;port=3306;password=" + pass;
            //MySqlConnection conn = new MySqlConnection(connStr);
            //try
            //{
            //    conn.Open();
            //    string sql = "SELECT * FROM `products` WHERE 1";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.Connection = conn;
            //    MySqlDataReader rdr = cmd.ExecuteReader();
            //    listView1.Items.Clear();
            //    while (rdr.Read())
            //    {
            //        listView1.Items.Add(rdr["Name"].ToString());
            //        listView1.Items.Add(rdr["Describes"].ToString());
            //        listView1.Items.Add(rdr["Price"].ToString());
            //        listView1.Items.Add(rdr["Fullname"].ToString());
            //        listView1.Items.Add(rdr["Image"].ToString());
            //    }
            //    rdr.Close();
            //    MessageBox.Show("Done!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //conn.Close();
            #endregion
            string valueToSearch = tbSearch.Text.ToString();
            searchData(valueToSearch);
        }
        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM products WHERE CONCAT(`ID`, `Name`, `Describes`, `Price`, `Fullname`, `Image`) like '%" + valueToSearch + "'";
            command = new MySqlCommand(query, connection);
            da = new MySqlDataAdapter(command);
            dt = new DataTable();
            da.Fill(dt);
            listView1.Items.Add(dt.ToString()); // add datagrid
        }
    }
}

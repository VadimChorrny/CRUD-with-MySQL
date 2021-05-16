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
using user_start_page.Chat;
using user_start_page.NewFolder;

namespace user_start_page
{
    public partial class UserMenu : Form
    {
        UnloadProduct unload;

        public UserMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageForm mf = new MessageForm();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string pass = "";
            string connStr = "server=localhost;user=root;database=product;port=3306;password=" + pass;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                conn.Open();
                string sql = "SELECT ID,Name,Describes,Price,Fullname FROM products WHERE Name = @Name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                string user_input = txtSearch.Text;
                cmd.Parameters.AddWithValue("@Name", user_input);
                MySqlDataReader rdr = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (rdr.Read())
                {
                    listBox1.Items.Add(rdr["Name"]);
                    listBox1.Items.Add(rdr["Describes"]);
                    listBox1.Items.Add(rdr["Price"]);
                    listBox1.Items.Add(rdr["Fullname"]);
                }
                rdr.Close();
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
    }
}

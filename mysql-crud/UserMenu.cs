using mysql_crud.myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mysql_crud
{
    public partial class UserMenu : Form
    {
        CRUD crud;

        public UserMenu()
        {
            InitializeComponent();
        }

        private void btnMyProducts_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //crud.Search_data();
            //dataGridView1.DataSource = crud.dt;
            string pass = "";
            string connStr = "server=localhost;user=root;database=product;port=3306;password=" + pass;
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
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

        private void button3_Click(object sender, EventArgs e)
        {
            DonateForm df = new DonateForm();
            df.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditAccount ed = new EditAccount();
            ed.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivityForm activity = new ActivityForm();
            activity.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChatForm chat = new ChatForm();
            chat.Show();
        }
    }
}

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

        private Users users;
        private string fileName;

        public RegistrationForm()
        {
            InitializeComponent();
            var fileDir = AppDomain.CurrentDomain.BaseDirectory;
            fileName = Path.Combine(fileDir, "user.bin"); // get name file
            if (File.Exists(fileName))
                using (var fs = File.OpenRead(fileName))
                    users = (Users)new BinaryFormatter().Deserialize(fs);
            else
                users = new Users();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chNewAccount.Checked)
            {
                users.SignupNewUser(tbLogin.Text, tbPassword.Text);
                using (var fs = File.OpenWrite(fileName))
                    new BinaryFormatter().Serialize(fs, users);
            }
            else
            {
                users.SignIn(tbLogin.Text, tbPassword.Text);
            }

            UserMenu user = new  UserMenu();
            user.Show();
            this.Visible = false;
        }
    }
}

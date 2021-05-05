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
    public partial class DonateForm : Form
    {
        public DonateForm()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri("http://google.com");
            webBrowser1.Navigate("https://patreon.com/chorrny?utm_medium=social&utm_source=twitter&utm_campaign=creatorshare ");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(int id, string login, string password) : this()
        {
            this.textBox1.Text = id.ToString();
            this.textBox2.Text = login;
            this.textBox3.Text = password;
        }
    }
}

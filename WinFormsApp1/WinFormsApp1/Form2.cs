using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Server=HOME;Database=TestUserDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT [USER]([Login], [Password]) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "')", conn);
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}

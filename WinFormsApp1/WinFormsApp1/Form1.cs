using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        int y = 50;
        int countUser = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Download_DataBase()
        {
            using (SqlConnection connection = new SqlConnection("Server=HOME;Database=TestUserDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [USER]", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserControl1 item = new UserControl1(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                    item.Name = $"User_{countUser++}";
                    item.Location = new Point(0, y);
                    this.Controls.Add(item);
                    y += item.Height - 1;
                }
            }
            y = 50;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Download_DataBase();
        }
        private void Change_Language(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            CultureInfo culture = new CultureInfo(lang);
            foreach (Control item in this.Controls)
                manager.ApplyResources(item, item.Name, culture);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Change_Language("en");
        }

        private void ukranianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("uk");
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("es");
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("de");
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Language("fr");
        }
        private void updateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (countUser != 0)
            {
                this.Controls.RemoveByKey($"User_{countUser--}");
            }
            countUser = 1;
            Download_DataBase();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.FormClosed += updateListToolStripMenuItem_Click;
            newForm.FormClosed += Form1_Load;
        }

    }
}
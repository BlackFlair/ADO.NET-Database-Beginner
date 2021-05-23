using System;
using System.Windows.Forms;

namespace Database_Assessment
{
    public partial class Login : Form
    {
        TempleDBEntities ctx;

        public Login()
        {
            InitializeComponent();
            CenterToScreen();

            ctx = new TempleDBEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = idTB.Text;
            var password = passwordTB.Text;

            if (id == "admin" && password == "123")
            {
                this.Hide();
                Home Check = new Home();
                Check.Show();
            }
            else
            {
                idTB.Text = "";
                passwordTB.Text = "";
                MessageBox.Show("Error: Invalid credentials.\n\nTry again!", "Error");
            }
        }
    }
}
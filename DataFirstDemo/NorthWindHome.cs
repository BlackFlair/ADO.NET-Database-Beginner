using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFirstDemo
{
    public partial class NorthWindHome : Form
    {
        NorthwindEntities ctx;

        public NorthWindHome()
        {
            InitializeComponent();
            CenterToScreen();
            ctx = new NorthwindEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prod = ctx.Products.Find(5);
            MessageBox.Show($"{prod.ProductName} belongs to {prod.Category.CategoryName} category.");
        }
    }
}

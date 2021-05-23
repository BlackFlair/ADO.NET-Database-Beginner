using System;
using System.Linq;
using System.Windows.Forms;

namespace Database_Assessment
{
    public partial class Home : Form
    {
        TempleDBEntities ctx;

        public Home()
        {
            InitializeComponent();
            CenterToScreen();

            ctx = new TempleDBEntities();
        }
  

        //----- Priests -----
        private void priestViewBtn_Click(object sender, EventArgs e)
        {
            var priests = ctx.Priests.Select(x => new
            {
                x.PriestID,
                x.Name,
                x.DOJ,
                x.LockerNumber
            });
            dataGridView1.DataSource = priests.ToList();
        }


        //----- Responsibilities -----
        private void button2_Click_1(object sender, EventArgs e)
        {
            var responsibility = ctx.Responsibilities.Select(x => new
            {
                x.ResponsibilityID,
                x.Responsibility1
            });
            dataGridView1.DataSource = responsibility.ToList();
        }


        //----- Sweet Dishes -----
        private void button4_Click(object sender, EventArgs e)
        {
            var sweetDishes = ctx.SweetDishesLists.Select(x => new
            {
                x.ItemID,
                x.DishName,
                x.CostPerPlate
            });
            dataGridView1.DataSource = sweetDishes.ToList();
        }


        //----- Rice Items -----
        private void button5_Click_1(object sender, EventArgs e)
        {
            var riceItems = ctx.RiceItemsLists.Select(x => new
            {
                x.ItemID,
                x.DishName,
                x.CostPerPlate
            });
            dataGridView1.DataSource = riceItems.ToList();
        }


        //----- Expences -----
        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                var expences = ctx.Expences.Select(x => new
                {
                    x.Date,
                    x.Daily,
                    x.Monthly,
                    x.Yearly
                });
                dataGridView1.DataSource = expences.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

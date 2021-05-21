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
            //strongly typed 
            //var prodName = ctx.Products.First().ProductName;
            //ctx.Database.Log = Console.Write;

            //var prodName = ctx.Products.Find(1).ProductName;

            //function syntax
            //var prodsWithSInIt = ctx.Products.Where(p => p.ProductName.Contains("s")).Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    p.UnitPrice
            //});

            //query syntax
            //var prodsSelected = from p in ctx.Products
            //                    where p.ProductName.ToLower().Contains("s")
            //                    select new
            //                    {
            //                        p.ProductID,
            //                        p.ProductName,
            //                        p.UnitsInStock
            //                    };

            //dataGridView1.DataSource = prodsSelected.ToList();

            //foreach (var p in prods)
            //    Console.WriteLine($"ID: {p.ProductID} Name: {p.ProductName}");

            //Category in prod object is a navigation property
            //MessageBox.Show($"{prod.ProductName} belongs to {prod.Category.CategoryName} category");

            //Product firstProd = ctx.Products.First();
            //var strCategoryName = firstProd.Category.CategoryName;

            //string name = null;
            //var qry = $"SELECT * FROM Products WHERE ProductID = {name}";


            //var strCatName = ctx.Products.Find(1).Category.CategoryName;       
            //MessageBox.Show(prodName);


            //
            //
            //Questions
            //
            //

            //1. Give the first name and city of employees living in USA

            //var query1 = ctx.Employees.Where(x=>x.Country.Equals("USA")).Select(x=>new
            //{
            //    x.FirstName,
            //    x.City
            //});
            //dataGridView1.DataSource = query1.ToList();


            //2. Give the first name and city of employees who have taken more than 100 orders

            //var query2 = ctx.Employees.Where(x => x.Orders.Count > 100).Select(
            //    x => new
            //    {
            //        x.FirstName,
            //        x.City
            //    });
            //dataGridView1.DataSource = query2.ToList();


            //3. Give the first name and last name of employees living in London and have shipped some order to London itself

            //var query3 = ctx.Employees.Where(x => x.City.Equals("London") && ctx.Orders.Where(y => y.ShipCity.Equals("London")).Any()).Select(x => new
            //{
            //    x.FirstName,
            //    x.LastName
            //});
            //dataGridView1.DataSource = query3.ToList();


            //4. Northwind wants to reward super performers. Find those who have taken more than 150 orders and manage more than two territories

            //var query4 = ctx.Employees.Where(x => x.Orders.Count > 150 && x.Territories.Count > 2).Select(x => new
            //{
            //    x.FirstName
            //});
            //dataGridView1.DataSource = query4.ToList();


            //5. Identify the customers who have placed order for more than 20 Tofu at once

            var query5 = ctx.Order_Details.Where(x => x.Quantity > 20 && x.Product.ProductName == "Tofu" && x.ProductID == x.Product.ProductID && x.OrderID == x.Order.OrderID && ctx.Customers.Where(y => y.CustomerID == x.Order.CustomerID).Any()).Select(x=>new
            {
                x.Order.CustomerID,
                x.Order.Customer.CompanyName,
                x.Order.Customer.ContactName,
                x.Quantity
            });
            dataGridView1.DataSource = query5.ToList();
        }
    }
}

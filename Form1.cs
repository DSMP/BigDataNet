using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigDataNet
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = db.Categories;
            var result = from category in query
                         join prod in db.Products on category.CategoryID equals prod.ProductID
                         let magazyn = prod.UnitsInStock * prod.UnitPrice
                         where prod.ProductID < 20
                         select category; 
                         //new
                         //{
                         //    Category = category.CategoryName,
                         //    Product = prod.ProductName,
                         //    WartoscProd = prod.UnitPrice,
                         //    magazyn
                         //};
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();
        }
    }
}

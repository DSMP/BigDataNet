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
    public partial class Form2 : Form
    {
        DataClasses1DataContext db;
        public Form2()
        {
            db = new DataClasses1DataContext();
            InitializeComponent();
            productBindingSource.DataSource = db.Products;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();
        }
    }
}

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
    public partial class Form4 : Form
    {
        DataClasses1DataContext db;
        public Form4()
        {
            db = new DataClasses1DataContext();
            InitializeComponent();
            categoryBindingSource.DataSource = db.Categories;

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

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
    public partial class Form5 : Form
    {
        DataClasses1DataContext db;
        public Form5()
        {
            db = new DataClasses1DataContext();
            InitializeComponent();
            customerBindingSource.DataSource = db.Customers;
        }
    }
}

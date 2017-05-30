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
    public partial class Form3 : Form
    {
        DataClasses1DataContext db;
        public Form3()
        {
            db = new DataClasses1DataContext();
            InitializeComponent();
            var query = from item in db.Employees
                        where item.EmployeeID < 5
                        select item;
            employeeBindingSource.DataSource = query;

        }
    }
}

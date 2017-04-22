using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigDataNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start DB");
            var builder = new SqlConnectionStringBuilder();
            //builder.DataSource = "IBM-08";
            //builder.InitialCatalog = "Northwind";
            Console.Write("User: "); builder.UserID = Console.ReadLine().ToString();
            Console.Write("Passowrd: "); builder.Password = Console.ReadLine().ToString();
            String str = ConfigurationManager.AppSettings["sqlconnectionstring"];
            Console.WriteLine(str + "UserID=" + builder.UserID + ";Password=" + builder.Password + ";");
            DbConnection conn1 =
            //new SqlConnection(@"Data Source = IBM-08;Initial Catalog=Northwind;User ID = sa; Password = praktyka");
            new SqlConnection("Data Source=IBM-08;Initial Catalog=Northwind;Integrated Security=True;" + "UserID=" + builder.UserID.ToString() + ";Password=" + builder.Password.ToString() + ";");
            conn1.StateChange += Conn1_StateChange;
            try
            {
                conn1.Open();
                Console.WriteLine("dziala db");
                conn1.Close();
            }
            catch (NullReferenceException)
            {
            }
            finally
            {
                conn1.Close();
            }
            Console.ReadKey();
        }

        private static void Conn1_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine(e.CurrentState.ToString());
            MessageBox.Show(e.CurrentState.ToString());
        }
    }
}

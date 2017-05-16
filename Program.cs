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
            //    Console.WriteLine("Start DB");
            //    var builder = new SqlConnectionStringBuilder();
            //    //builder.DataSource = "IBM-08";
            //    //builder.InitialCatalog = "Northwind";
            //    Console.Write("User: "); builder.UserID = Console.ReadLine().ToString();
            //    Console.Write("Passowrd: "); builder.Password = Console.ReadLine().ToString();
            //    String str = ConfigurationManager.AppSettings["sqlconnectionstring"];
            //    Console.WriteLine(str + "User ID=" + builder.UserID + ";Password=" + builder.Password + ";");
            //    SqlConnection conn1 =
            //    //new SqlConnection(@"Data Source = IBM-08;Initial Catalog=Northwind;User ID = sa; Password = praktyka"); DESKTOP-EJMT7JC
            //    new SqlConnection(str + "User ID=" + builder.UserID.ToString() + ";Password=" + builder.Password.ToString() + ";");
            //    conn1.StateChange += Conn1_StateChange;
            //    SqlCommand command = new SqlCommand("GetPersons", conn1);
            //    command.CommandType = System.Data.CommandType.StoredProcedure;
            //    command.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.VarChar,50)).Value = "%";
            //    command.Parameters.Add(new SqlParameter("@count", System.Data.SqlDbType.Int));
            //    command.Parameters["@count"].Direction = System.Data.ParameterDirection.Output;
            //    //SqlDataReader reader = command.ExecuteReader();
            //    try
            //    {
            //        conn1.Open();
            //        Console.WriteLine("{0} {1}", "Count: ", command.Parameters["@count"].Value.ToString());
            //        conn1.Close();
            //    }
            //    catch (NullReferenceException)
            //    {
            //    }
            //    finally
            //    {
            //        conn1.Close();
            //    }
            //    Console.ReadKey();
            //}

            //private static void Conn1_StateChange(object sender, System.Data.StateChangeEventArgs e)
            //{
            //    Console.WriteLine(e.CurrentState.ToString());
            //    MessageBox.Show(e.CurrentState.ToString());
            //}

            string[] names = { "Ala", "Adam", "Tomek", "Piotr", "Ewa", "Ania", "Kamil" };

            var result = from name in names
                         where name.Length < 5
                         orderby name
                         select name.ToUpper();

            var result2 = names.Where(w => w.Length < 5).OrderBy(w => w).Select(w => w.ToUpper());

            foreach (string item in result2)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}

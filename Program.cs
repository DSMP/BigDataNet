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

            var employees = new List < Employee >{
                new Employee { FirstName = "Adam", LastName = "Nowak", Salary = 1000, StartDate = DateTime.Parse("1/4/2008") },
                new Employee { FirstName = "Jan", LastName = "Kowalski", Salary = 1200, StartDate = DateTime.Parse("1/6/2012") },
                new Employee { FirstName = "Michal", LastName = "Rolo", Salary = 1500, StartDate = DateTime.Parse("1/2/2002") },
            };
            var query = from employee in employees
                        where employee.Salary > 1200
                        select new
                        {
                            Imie = employee.FirstName,
                            Nazwisko = employee.LastName
                        };
            foreach (var item in query)
                Console.WriteLine(item.Imie + " " + item.Nazwisko);

            Console.ReadKey();
        }
    }
}

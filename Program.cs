﻿using System;
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
            Console.WriteLine(str + "User ID=" + builder.UserID + ";Password=" + builder.Password + ";");
            SqlConnection conn1 =
            //new SqlConnection(@"Data Source = IBM-08;Initial Catalog=Northwind;User ID = sa; Password = praktyka"); DESKTOP-EJMT7JC
            new SqlConnection(str + "User ID=" + builder.UserID.ToString() + ";Password=" + builder.Password.ToString() + ";");
            conn1.StateChange += Conn1_StateChange;
            //SqlCommand command = ;
            try
            {
                conn1.Open();
                SqlDataReader reader = new SqlCommand("select ProductID, ProductName, UnitPrice, UnitsInStock from products where UnitPrice IS NOT NULL", conn1).ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", reader[0], reader[1], reader[2], reader[3]);
                }
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

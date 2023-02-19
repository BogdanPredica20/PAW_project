using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace Proiect_PAW
{
    public partial class Baza_date : Form
    {
        
        public Baza_date()
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider); 
            
            using (DbConnection connection = factory.CreateConnection())
            {
                if(connection == null)
                {
                    Console.WriteLine("Connection Error");
                    Console.ReadLine();
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if(command == null)
                {
                    Console.WriteLine("Command Error");
                    Console.ReadLine();
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * From Clienti";

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        Console.WriteLine($"{dataReader["Nume"]} " +
                            $"{dataReader["Prenume"]}");
                    }
                }
                Console.ReadLine();
            }


            InitializeComponent();
        }
    }
}

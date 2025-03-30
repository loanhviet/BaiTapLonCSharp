using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ComputerStore.DAL
{
    public class DatabaseHelper
    {   
        
        private static string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=ComputerStoreDB;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}

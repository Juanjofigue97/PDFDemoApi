using DataAccessLibrary;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerUI
{
    public static class HelperConnection
    {
        public static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName)!;

            return output;
        }

        public static void ReadAllContacts(SqlCrud sql)
        {
            var rows = sql.GetAllUsers();
            foreach (var row in rows)
            {
                Console.WriteLine($"{ row.Id }. { row.FirstName } ");
            }

        }
    }
}

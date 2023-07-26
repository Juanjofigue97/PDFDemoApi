using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary;

public class SqlDataAccess
{
    public List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionString)
    {
        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            // Query -> Ready
            List<T> rows = connection.Query<T>(sqlStatement).ToList();
            return rows;
        }

    }

    public void SaveData<T>(string sqlStatement, T parameters, string connectionString)
    {
        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            // Execute -> Write
            connection.Execute(sqlStatement, parameters);
        }
    }
}

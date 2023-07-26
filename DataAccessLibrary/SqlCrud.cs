using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;
        private SqlDataAccess db = new SqlDataAccess();
        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicUserModel> GetAllUsers() 
        {
            string sql = "SELECT Id,FirstName,Password FROM dbo.Users";

            return db.LoadData<BasicUserModel, dynamic>(sql, new { }, _connectionString);

        }

        //public BasicUserModel GetFullUserById(int id)
        //{
        //    throw new NotImplementedException;
        //}

    }
}

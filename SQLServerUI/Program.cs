
using SQLServerUI;
using DataAccessLibrary;
using DataAccessLibrary.Models;


SqlCrud sql = new SqlCrud(HelperConnection.GetConnectionString("Default"));

HelperConnection.ReadAllContacts(sql); 



Console.ReadLine();


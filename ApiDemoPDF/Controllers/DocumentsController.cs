using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiDemoPDF.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IConfiguration _config;

        private static void ReadAllContacts(SqlCrud sql)
        {
            var rows = sql.GetAllUsers();
        }

        public DocumentsController(IConfiguration config)
        {
            _config = config;
        }
        // GET: api/<DocumentsController>
        [HttpGet]
        public IEnumerable<BasicUserModel> Get()
        {
            var connection = _config.GetConnectionString("Default");
            SqlCrud sql = new SqlCrud(connection);
            
            return sql.GetAllUsers(); 
        }

        // GET api/<DocumentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DocumentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DocumentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DocumentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

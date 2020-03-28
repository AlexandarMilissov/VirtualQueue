using System.Collections.Generic;
using System.Web.Http;
using SQL_Connection.Entities;
using SQL_Connection;
using System.Linq;

namespace VQServer.Controllers
{
    public class DataController : ApiController
    {
        // GET api/<controller>
        [Route("api/queues")]
        [HttpGet]
        public List<Queue> GetUsers()
        {
            SQL_Connection.DB_Connection DBAccess = new DB_Connection();
            return DBAccess.Queues.Select(u => new Queue() { Id = u.Id, LocationAddress = u.LocationAddress, LocationName = u.LocationName, Manager = u.Manager, Users = u.Users}).ToList<Queue>();
        }
        // POST api/<controller>
        public void Register([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
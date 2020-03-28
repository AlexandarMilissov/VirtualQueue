using System.Collections.Generic;
using System.Web.Http;

namespace VQServer.Controllers
{
    public class DataController : ApiController
    {
        // GET api/<controller>
        [Route("api/Users")]
        [HttpGet]
        public List<Models.Users> GetUsers()
        {
            List <Models.Users> users = new List<Models.Users>();
            
            return users;
        }

        [Route("api/Managers")]
        [HttpGet]
        public List<Models.Managers> GetManagers()
        {
            List<Models.Managers> managers = new List<Models.Managers>();

            return managers;
        }

        [Route("api/Queues")]
        [HttpGet]
        public List<Models.Queues> GetQueues()
        {
            List<Models.Queues> queues= new List<Models.Queues>();

            return queues;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
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
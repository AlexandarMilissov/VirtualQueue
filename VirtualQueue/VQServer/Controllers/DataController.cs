using System.Collections.Generic;
using System.Web.Http;
using SQL_Connection.Entities;
using SQL_Connection;
using System.Linq;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using System;

namespace VQServer.Controllers
{
    public class DataController : ApiController
    {
        DB_Connection DBAccess = new DB_Connection();
        // GET api/<controller>
        [Route("api/queues")]
        [HttpGet]
        public List<Queue> GetUsers()
        {
            return DBAccess.Queues.Select(u => new Queue() { Id = u.Id, LocationAddress = u.LocationAddress, LocationName = u.LocationName, Manager = u.Manager, Users = u.Users}).ToList<Queue>();
        }
        // POST api/<controller>
        public void RegisterUser([FromBody]User user)
        {
            string macadd = "";
            User curuser = new User();
            curuser.Id = user.Id;
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces, thereby ignoring any
                // loopback devices etc.
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Ethernet) continue;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macadd += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            curuser.MacAddress = macadd;
            curuser.Queue = user.Queue;
            DBAccess.Add(curuser);
        }

        public void DeleteUserFromQueue(int id, [FromBody] User user)
        {
            User curuser = new User();
            foreach (User user in DBAccess.Users)
            {
                if(user.Id == id)
                {
                    curuser.Id = user.Id;
                    //curuser.IsEnqueued = false; 
                }
            }
            DBAccess.Remove(curuser);
        }
        /*
        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        */
    }
}
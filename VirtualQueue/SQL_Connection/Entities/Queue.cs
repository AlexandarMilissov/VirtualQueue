using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection.Entities
{
    public class Queue
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public List<User> Users { get; set; }
        public Manager Manager { get; set; }
    }
}

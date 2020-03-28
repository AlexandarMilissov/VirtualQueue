using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string MacAddress { get; set; }
        public Queue Queue { get; set; }
    }
}

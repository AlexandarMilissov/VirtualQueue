using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VQServer.Models
{
    public class Users
    {
        public int userId { get; set; }
        public string mac { get; set; }
        public int queueId { get; set; }
        public int[] location { get; set; }

    }
}
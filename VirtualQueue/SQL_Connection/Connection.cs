using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Connection
{
    public class DB_Connection : DbContext
    {
        protected void GetConnectionString(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=VirtualQueueDB;Trusted_Connection=True;Integrated Security = True;");
        }
    }
}

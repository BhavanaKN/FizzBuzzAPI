using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(){

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public virtual DbSet<FizzBuzz> FizzBuzz { get; set; }
    }
}

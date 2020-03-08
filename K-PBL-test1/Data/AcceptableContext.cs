using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using K_PBL_test1.Models;

namespace K_PBL_test1.Data
{
    public class AcceptableContext : DbContext
    {

        public AcceptableContext (DbContextOptions<AcceptableContext> options)
            :base(options)
        {   
        }
        public DbSet<Center> Centers { get; set; }
        public DbSet<AcceptableLevel> AcceptableLevels { get; set; }


    }
}

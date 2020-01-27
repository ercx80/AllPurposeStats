using AllPurposeStats.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.Data
{
    public class StatsDbContext : DbContext 
    {
        public DbSet<Statline> Stats { get; set; }
        public StatsDbContext(DbContextOptions<StatsDbContext> options)
            :base (options)
        { }
    }
}

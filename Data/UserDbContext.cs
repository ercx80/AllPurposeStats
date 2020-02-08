using AllPurposeStats.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllPurposeStats.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }//Users is the DBsets of my users
        public DbSet<Player> Players { get; set; }//Player is the DBsets of my players
        public DbSet<Statline> Stats { get; set; }//Statline is the DBsets of my stats
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        { }
    }
}

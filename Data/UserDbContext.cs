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
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Goals.Models
{
    public class GoalContext : DbContext
    {
        public DbSet<Goal> Goals { get; set; }
        public DbSet<UserList> UserLists { get; set; }
    }
}
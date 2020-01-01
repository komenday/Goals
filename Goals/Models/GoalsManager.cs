using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goals.Models
{
    public class GoalsManager
    {
        public IEnumerable<Goal> AllGoals { get; set; }
        public IEnumerable<Goal> PlannedGoals { get; set; }
        public IEnumerable<Goal> ImportantGoals { get; set; }
        public IEnumerable<Goal> TodaysGoals { get; set; }
        public IEnumerable<Goal> CompletedGoals { get; set; }
        public IEnumerable<UserList> UserLists { get; set; }
        //public GoalsManager(IEnumerable<Goal> goals, )
        //{
        //    AllGoals
        //}
    }
}
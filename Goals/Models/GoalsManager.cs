using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goals.Models
{
    public class GoalsManager
    {
        public List<Goal> AllGoals { get; set; }
        public List<Goal> PlannedGoals = new List<Goal>();
        public List<Goal> ImportantGoals = new List<Goal>();
        public List<Goal> TodaysGoals = new List<Goal>();
        public List<Goal> CompletedGoals = new List<Goal>();
        public List<UserList> UserLists;
        public GoalsManager(IEnumerable<Goal> goals, IEnumerable<UserList> userLists = null)
        {
            AllGoals = goals.ToList();
            SetSmartLists();
            UserLists = userLists?.ToList();
        }

        public void SetSmartLists()
        {
            ClearSmartLists();

            for (int i = 0; i < AllGoals.Count; i++)
            {
                if (AllGoals[i].State == GoalState.Completed)
                {
                    CompletedGoals.Add(AllGoals[i]);
                    AllGoals.Remove(AllGoals[i]);
                    i--;
                    continue;
                }
                if (AllGoals[i].DueDate.HasValue) PlannedGoals.Add(AllGoals[i]);
                if (AllGoals[i].Importance == GoalImportance.High) ImportantGoals.Add(AllGoals[i]);
                if (AllGoals[i].DueDate == DateTime.Today) TodaysGoals.Add(AllGoals[i]);

            }
        }

        public void ClearSmartLists()
        {
            PlannedGoals.Clear();
            ImportantGoals.Clear();
            TodaysGoals.Clear();
            CompletedGoals.Clear();
        }
    }
}
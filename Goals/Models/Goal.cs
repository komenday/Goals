using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goals.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public GoalImportance Importance { get; set; }
        public DateTime? DueDate { get; set; }
        public GoalState State { get; set; }
        public Goal()
        {

        }
        public Goal(string title, string description, GoalImportance importance, GoalState goalState)
        {
            Title = title;
            Description = description;
            Importance = importance;
            State = goalState;
        }
        public Goal(string title, string description, GoalImportance importance, DateTime dueDate, GoalState goalState)
        {
            Title = title;
            Description = description;
            Importance = importance;
            DueDate = dueDate;
            State = goalState;
        }
    }
}
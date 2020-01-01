using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Goals.Models
{
    public class GoalDbInitializer : DropCreateDatabaseAlways<GoalContext>
    {
        protected override void Seed(GoalContext db)
        {
            db.Goals.Add(new Goal("Write an essay", "About...", GoalImportance.Normal, GoalState.Active));
            db.Goals.Add(new Goal("Complete the task", "for Levi9", GoalImportance.High, new DateTime(2020, 1, 6), GoalState.Completed));
            db.Goals.Add(new Goal("Make a cake", "with a chocolate", GoalImportance.Low, new DateTime(2019, 12, 23), GoalState.Active));
            db.Goals.Add(new Goal("Write an email", "...", GoalImportance.High, new DateTime(2019, 12, 23), GoalState.Active));
            db.Goals.Add(new Goal("Do sport", "...", GoalImportance.Normal, new DateTime(2020, 01, 01), GoalState.Active));
            db.Goals.Add(new Goal("Clean my room", "with a chocolate", GoalImportance.Normal, new DateTime(2019, 12, 15), GoalState.Completed));

            base.Seed(db);
        }
    }
}
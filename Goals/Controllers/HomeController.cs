using Goals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Goals.Controllers
{
    public class HomeController : Controller
    {
        static public GoalContext db = new GoalContext();
        static public GoalsManager goalsManager;

        public ActionResult Index()
        {
            goalsManager = new GoalsManager(db.Goals);
            return View();
        }

        [HttpGet]
        public ActionResult AddGoal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGoal(Goal goal)
        {
            goal.Id = goalsManager.AllGoals.Count + 1;
            db.Goals.Add(goal);
            db.SaveChanges();
            return Index();
        }
    }
}
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
        public GoalsManager Manager { get; set; }

        GoalContext db = new GoalContext();
        IEnumerable<Goal> dbgoals;

        public ActionResult Index()
        {
            dbgoals = db.Goals;
            return View();
        }

        public ActionResult All()
        {
            return View(db.Goals);
        }
    }
}
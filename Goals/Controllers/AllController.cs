using Goals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Goals.Controllers
{
    public class AllController : Controller
    {
        public ActionResult Index()
        {
            return View(HomeController.goalsManager.AllGoals);
        }
    }
}
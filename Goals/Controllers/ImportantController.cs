using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Goals.Controllers
{
    public class ImportantController : Controller
    {
        public ActionResult Index()
        {
            return View(HomeController.goalsManager.ImportantGoals);
        }
    }
}
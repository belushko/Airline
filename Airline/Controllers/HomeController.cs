using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airline.Controllers
{
    public class HomeController : Controller
    {
        Repository r = new Repository();
        public ActionResult Index()
        {
           
            return View(r.GetFlights());
        }


    }
}

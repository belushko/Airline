using Business.Logic;
using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airline.Controllers
{
    public class FlightController : Controller
    {
        FlightLogic logic = new FlightLogic();

        //
        // GET: /Flight/

        public ActionResult Index()
        {
            return View(logic.GetFlights());
        }

        //
        // GET: /Flight/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Flight/Create

        [HttpPost]
        public ActionResult Create(Flight flight)
        {
            try
            {
                // TODO: Add insert logic here
                logic.Create(flight);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Flight/Delete/5

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return View();
        }





        //
        // GET: /Flight/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Flight/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Flight/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}

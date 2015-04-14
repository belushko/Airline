using Airline.Models;
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
        FlightStatusLogic flightStatusLogic = new FlightStatusLogic();
        //
        // GET: /Flight/

        public List<SelectListItem> GetStatusList()
        {
            List<SelectListItem> list = flightStatusLogic.GetFlightStatuses().Select(x =>
                new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.FlightStatusId.ToString()
                }
                ).ToList();
            return list;
        }

        public ActionResult Index()
        {

            return View(logic.GetFlights());
        }

        //
        // GET: /Flight/Create

        public ActionResult Create()
        {
            FlightView flight = new FlightView();


            List<SelectListItem> list = flightStatusLogic.GetFlightStatuses().Select(x =>
                new SelectListItem()
                {
                    Text = x.Name,
                    Value = x.FlightStatusId.ToString()
                }
                ).ToList();
            flight.StatusList = list;

            //easy
            flight.From = "Харьков";
            flight.To = "Москва";
            flight.Name = "Имя";
            flight.ArrivalDate = DateTime.Now;
            flight.DepatureDate = DateTime.Now;

            return View(flight);
        }

        //
        // POST: /Flight/Create

        [HttpPost]
        public ActionResult Create(FlightView flightView)
        {
            try
            {
                Flight flight = new Flight();
                int statusId = int.Parse(flightView.StatusId);
                FlightStatus status = flightStatusLogic.GetFlightStatusById(statusId);

                flight.Status = status;
                flight.FlightId = flightView.FlightId;
                flight.From = flightView.From;
                flight.To = flightView.To;
                flight.Name = flightView.Name;
                flight.ArrivalDate = flightView.ArrivalDate;
                flight.DepatureDate = flightView.DepatureDate;



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

        public ActionResult Delete(int FlightId)
        {
            return View(logic.GetFlightById(FlightId));
        }

        [HttpPost]
        public ActionResult Delete(int flightId, FormCollection form)
        {

            logic.Delete(flightId);
            return RedirectToAction("Index");
        }





        //
        // GET: /Flight/Edit/5

        public ActionResult Edit(int id)
        {
            Flight flight = logic.GetFlightById(id);
            FlightView flightView = new FlightView();

            //mapping       -> automapping
            flightView.StatusList = GetStatusList();
            flightView.From = flight.From;
            flightView.To = flight.To;
            flightView.Name = flight.Name;
            flightView.ArrivalDate = flight.ArrivalDate;
            flightView.DepatureDate = flight.DepatureDate;
            flightView.FlightId = flight.FlightId;


            return View(flightView);
        }

        //
        // POST: /Flight/Edit/5

        [HttpPost]
        public ActionResult Edit(FlightView flightView, FormCollection collection)
        {
            try
            {
                Flight flight = new Flight();
                flight.FlightId = flightView.FlightId;
                flight.From = flightView.From;
                flight.To = flightView.To;
                flight.Name = flightView.Name;
                flight.ArrivalDate = flightView.ArrivalDate;
                flight.DepatureDate = flightView.DepatureDate;

                int statusId = int.Parse(flightView.StatusId);
                FlightStatus status = flightStatusLogic.GetFlightStatusById(statusId);
                flight.Status = status;
                logic.Edit(flight);
                //
                //

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
            Flight flight = logic.GetFlightById(id);
            return View(flight);
        }

    }
}

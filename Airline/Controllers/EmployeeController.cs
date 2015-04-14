using Airline.Models;
using Business.Logic;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airline.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeLogic empLogic = new EmployeeLogic();
        EmployeeTypeLogic empTypeLogic = new EmployeeTypeLogic();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            List<Employee> empls = empLogic.GetEmployees();
            List<EmployeeView> empViews = new List<EmployeeView>();
            foreach (Employee e in empls)
            {
                EmployeeView empView = new EmployeeView();
                empView.EmployeeId = e.EmployeeId;
                empView.FirstName = e.FirstName;
                empView.LastName = e.LastName;
                empView.Age = DateTime.Now.Year - e.DateOfBirth.Year;
                empView.Type = e.Type;
                empViews.Add(empView);
            }
            return View(empViews);
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
            Employee employee = empLogic.GetEmployeeById(id);
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            EmployeeView employeeView = new EmployeeView();

            employeeView.TypeList = GetTypeList();
            //easy
            employeeView.FirstName = "Василий";
            employeeView.LastName = "Максимов";
            employeeView.DateOfBirth = DateTime.Now;
            employeeView.TypeId = "1";

            return View(employeeView);
        }

        private List<SelectListItem> GetTypeList()
        {
            List<SelectListItem> list = empTypeLogic.GetEmployeeTypes().Select(e =>
                new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.EmployeeTypeId.ToString()
                }
                ).ToList();
            return list;
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(EmployeeView employeeView)
        {
            try
            {
                Employee employee = new Employee();
                int empViewId = int.Parse(employeeView.TypeId);
                EmployeeType empType = empTypeLogic.GetEmployeeTypeById(empViewId);

                employee.EmployeeId = employeeView.EmployeeId;
                employee.Type = empType;
                employee.EmployeeId = employeeView.EmployeeId;
                employee.FirstName = employeeView.FirstName;
                employee.LastName = employeeView.LastName;
                employee.DateOfBirth = employeeView.DateOfBirth;   

                empLogic.Create(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id)
        {
            Employee employee = empLogic.GetEmployeeById(id);
            EmployeeView empView = new EmployeeView();

            //mapping       -> automapping
            empView.TypeList = GetTypeList();
            empView.Age = DateTime.Now.Year - employee.DateOfBirth.Year;
            empView.EmployeeId = employee.EmployeeId;
            empView.FirstName = employee.FirstName;
            empView.LastName = employee.LastName;
            empView.Type = employee.Type;
            return View(empView);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(EmployeeView employeeView, FormCollection collection)
        {
            try
            {
                //type not edit
                Employee employee = new Employee();
                int empViewId = int.Parse(employeeView.TypeId);
                EmployeeType empType = empTypeLogic.GetEmployeeTypeById(empViewId);

                employee.EmployeeId = employeeView.EmployeeId;
                employee.Type = empType;
                employee.EmployeeId = employeeView.EmployeeId;
                employee.FirstName = employeeView.FirstName;
                employee.LastName = employeeView.LastName;
                employee.DateOfBirth = employeeView.DateOfBirth;

                empLogic.Edit(employee);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id)
        {
            Employee employee = empLogic.GetEmployeeById(id);
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                empLogic.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

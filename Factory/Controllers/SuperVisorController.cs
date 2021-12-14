using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class SuperVisorController : Controller
    {
        // GET: SuperVisor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SHowName()
        {
            ViewBag.Name = "Joan";
            return View();
        }
        public ActionResult ShowWorker()
        {

            return View(GetEmployee());
        }

        private static SuperVisor GetEmployee()
        {
            SuperVisor employee = new SuperVisor();
            employee.firstName = "Beni";
            employee.lastName = "Gavra";
            employee.dateOfBirth = 1997;
            employee.years = 5;
            return employee;
        }

        public ActionResult ShoeWorkersNames()
        {
            string[] employees = new string[] { "eden", "tikva", "Oshrit", "Matan", "liel", "ermi" };
            return View(employees);
        }
        public ActionResult ShowAllWorker()
        {

            return View(NewMethod());
        }

        private static List<SuperVisor> NewMethod()
        {
            List<SuperVisor> workersLsit = new List<SuperVisor>();
            workersLsit.Add(new SuperVisor("Haim", "Ayano", 1998, 5));
            workersLsit.Add(new SuperVisor("Yael", "Shalom", 1880, 15));
            return workersLsit;
        }
    }
}
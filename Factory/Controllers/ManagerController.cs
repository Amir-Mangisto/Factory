using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShoeName()
        {
            ViewBag.Name = "Daniel";
            return View();
        }
        public ActionResult ShowWorker()
        {
            return View(GetWorker2());
        }

        private static Manager GetWorker2()
        {
            Manager worker2 = new Manager();
            worker2.firstName = "shlomo";
            worker2.lastName = "wassa";
            worker2.department = "manager";
            return worker2;
        }

        public ActionResult ShoeWorkersNames()
        {
            string[] workerNames = new string[] { "asi", "dan", "ben", "amir", "daniel", "or" };
            return View(workerNames);
        }
        public ActionResult ShowAllWorker()
        {        
            return View(GetWorkerList());
        }

        private static List<Manager> GetWorkerList()
        {
            List<Manager> workerList = new List<Manager>();
            workerList.Add(new Manager("ascha", "asga", "Electrician"));
            workerList.Add(new Manager("matan", "sayas", "Reception"));
            workerList.Add(new Manager("ermi", "mangisto", "IT"));
            workerList.Add(new Manager("ascha", "asga", "Artist"));

            return workerList;
        }
    }
}
using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowName()
        {
            ViewBag.Name = "Israel";
            return View();
        }
        public ActionResult ShowWorker()
        {
          
            return View(GetWorker());
        }

        private static Employee GetWorker()
        {
            Employee worker1 = new Employee();
            worker1.firstName = "david";
            worker1.lastName = "bada";
            worker1.dateOfBirth = 1995;
            worker1.phone = 052556478;
            return worker1;
        }

        public ActionResult ShoeWorkersNames()
        {
            string[] workerNames = new string[] { "eli", "avi", "yoni", "oshri", "amir", "shimi" };
            ViewBag.WorkerNames = workerNames;
            return View();
        }
        public ActionResult ShowAllWorker()
        {
            return View(GetEmploeeList());
        }

        private static List<Employee> GetEmploeeList()
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee("shimon", "semay", 1995, 55669988));
            employee.Add(new Employee("avi", "admaso", 1994, 4422335));
            employee.Add(new Employee("eli", "beli", 1997, 2211334));
            employee.Add(new Employee("yoni", "tagania", 1994, 7788554));
            employee.Add(new Employee("jacob", "shiber", 1997, 1235654));
            employee.Add(new Employee("amir", "mangisto", 1999, 897454));
            return employee;
        }
    }
}
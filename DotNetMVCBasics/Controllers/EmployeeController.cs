using DotNetMVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMVCBasics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeelist = new List<Employee>();
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "kishan";
            employee.Salary = 5;
            employeelist.Add(employee);
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Raja";
            employee2.Salary = 10;
            employeelist.Add(employee2);
            return View(employeelist);
        }

        public ActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            return View();
        }

        public ActionResult UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Vi";
            employee.Salary = 4;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            return View(employee);
        }
    }
}
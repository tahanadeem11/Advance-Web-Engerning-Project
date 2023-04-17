using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            EmpContext employeeContext = new EmpContext();
            List<employe> employees = employeeContext.Employees.ToList();
            return View(employees);
        }

        public ActionResult Detail()
        {
            employe employe = new employe()
            {
                EmployeeID = 101,
                Name = "Taha",
                Gender = "Male",
                City = "lahore"
            };
            return View(employe);
        }

    }
}
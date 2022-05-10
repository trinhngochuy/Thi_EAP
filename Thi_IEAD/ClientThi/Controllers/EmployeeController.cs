using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientThi.Controllers
{
    public class EmployeeController : Controller
    {
        protected ServiceReference1.Service1Client service;
        public EmployeeController()
        {
            service = new ServiceReference1.Service1Client();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CreateEmployee(ServiceReference1.Employee employeeData)
        {
            var employee = service.Add(employeeData);
            return Json(employee);
        }
        public JsonResult Search(string key)
        {
            var Listemployee = service.Search(key);
            return Json(Listemployee);
        }

    }
}
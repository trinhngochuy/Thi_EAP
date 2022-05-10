using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Thi_IEAD.Data;
using Thi_IEAD.Entity;

namespace Thi_IEAD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Context db;
         public Service1()
        {
            db = new Context();
        }
        public Employee Add(Employee employee)
        {
            db.Employees.AddOrUpdate(employee);
            db.SaveChanges();
            return employee;
        }

        public IEnumerable<Employee> Search(string keyword)
        {
            List<Employee> employee = db.Employees.Where(s => s.Department.Contains(keyword)).ToList();
            return  employee;

        }
    }
}

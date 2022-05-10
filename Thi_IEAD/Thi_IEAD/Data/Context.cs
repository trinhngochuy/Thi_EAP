using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Thi_IEAD.Entity;

namespace Thi_IEAD.Data
{
    public class Context : DbContext
    {
        public Context() : base("DemoApp")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
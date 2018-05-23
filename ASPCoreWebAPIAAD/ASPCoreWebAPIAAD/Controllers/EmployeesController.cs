using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreWebAPIAAD.Models;

namespace ASPCoreWebAPIAAD.Controllers
{
    [Route("api/employees")]
    public class EmployeesController : Controller
    {
        private HRDbContext dbContext;
        public EmployeesController()
        {
            string connectionString = @"Server=WGHOSH6\SQL2017;Database=HRDb;User Id=blah;Password=blah;";
            dbContext = HRDbContextFactory.Create(connectionString);
        }

        [HttpGet]
        public Employee[] Get()
        {
            return dbContext.Employees.Take(100).ToArray();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return dbContext.Employees.SingleOrDefault(emp => emp.Id == id);
        }
    }
}
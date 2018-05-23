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
            string connectionString = @"";
            dbContext = HRDbContextFactory.Create(connectionString);
        }
        [HttpGet]
        public Employee[] Get()
        {
            return dbContext.Employees.ToArray();
        }
    }
}
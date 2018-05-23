using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreWebAPIAAD.Models;

namespace ASPCoreWebAPIAAD.Controllers
{
    [Route("api/kbooks")]
    public class KBooksController : Controller
    {
        KBookContext dbContext;
        public KBooksController()
        {
            string connectionString = @"Server=WGHOSH6\SQL2017;Database=HRDb;User Id=blah;Password=blah;";
            dbContext = KBookContextFactory.Create(connectionString);
        }

        [HttpGet]
        public KBook[] Get()
        {
            return dbContext.KBooks.ToArray();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebAPIAAD.Models
{
    public class HRDbContext : DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }

    public static class HRDbContextFactory
    {
        public static HRDbContext Create(string connectionString)
        {
            var optionBuilder = new DbContextOptionsBuilder<HRDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            var hrdbContext = new HRDbContext(optionBuilder.Options);
            return hrdbContext;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebAPIAAD.Models
{
    [Table("KBook")]
    public class KBook
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    public class KBookContext : DbContext
    {
        public KBookContext(DbContextOptions<KBookContext> options) : base(options) { }

        public DbSet<KBook> KBooks { get; set; }
    }

    public static class KBookContextFactory
    {
        public static KBookContext Create(string connectionString)
        {
            var optionBuilder = new DbContextOptionsBuilder<KBookContext>();
            optionBuilder.UseSqlServer(connectionString);

            var kbookContext = new KBookContext(optionBuilder.Options);
            return kbookContext;
        }
    }

}

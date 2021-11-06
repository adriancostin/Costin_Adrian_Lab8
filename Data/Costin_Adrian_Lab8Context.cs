using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costin_Adrian_Lab8.Models;

namespace Costin_Adrian_Lab8.Data
{
    public class Costin_Adrian_Lab8Context : DbContext
    {
        public Costin_Adrian_Lab8Context (DbContextOptions<Costin_Adrian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Costin_Adrian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Costin_Adrian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Costin_Adrian_Lab8.Models.Category> Category { get; set; }
    }
}

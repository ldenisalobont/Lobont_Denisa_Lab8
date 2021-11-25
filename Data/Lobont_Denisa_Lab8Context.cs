using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lobont_Denisa_Lab8.Models;

namespace Lobont_Denisa_Lab8.Data
{
    public class Lobont_Denisa_Lab8Context : DbContext
    {
        public Lobont_Denisa_Lab8Context (DbContextOptions<Lobont_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Lobont_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Lobont_Denisa_Lab8.Models.Publisher> Publisher { get; set; }
    }
}

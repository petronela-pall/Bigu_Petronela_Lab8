using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bigu_Petronela_Lab8.Models;

namespace Bigu_Petronela_Lab8.Data
{
    public class Bigu_Petronela_Lab8Context : DbContext
    {
        public Bigu_Petronela_Lab8Context (DbContextOptions<Bigu_Petronela_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bigu_Petronela_Lab8.Models.Book> Book { get; set; }

        public DbSet<Bigu_Petronela_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Bigu_Petronela_Lab8.Models.Category> Category { get; set; }
    }
}

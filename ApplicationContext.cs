using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Приемная_комиссия.Haracteristika;

namespace Приемная_комиссия
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Abiturient> AbiturientsDB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abiturient>().HasKey(u => u.Id);
        }
    }
}

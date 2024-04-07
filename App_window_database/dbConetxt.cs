using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_window_database
{
    internal class dbConetxt : DbContext
    {
        public DbSet<dbStructure> Rates { get; set; }
        public dbConetxt()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Problem plecakowy\Apka_bazodanowa\App_window_database\exchangeRates.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dbStructure>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.currency).IsRequired();
                entity.Property(e => e.rate).IsRequired();
            });
        }
    }
}

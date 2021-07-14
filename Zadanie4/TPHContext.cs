using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Zadanie4
{
    public class TPHContext : DbContext  
    {
        public DbSet<Osoba> Osoby { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pracownik>().ToTable("Pracownik");
            modelBuilder.Entity<Klient>().ToTable("Klient");
        }

        // Tworzę "baze" i zapisuję ją jako TPH
        protected override void OnConfiguring(DbContextOptionsBuilder optionBulder)
        {
            optionBulder.UseSqlServer(@"Data Source=DESKTOP-UK1AL1K;Integrated Security=True;Initial Catalog = TPH;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionBulder);
        }


    }
}

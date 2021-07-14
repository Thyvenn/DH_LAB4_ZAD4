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
    public class TPTContext : DbContext
    {
        public DbSet<Osoba> Osoba { get; set; }
        public DbSet<Klient> Klient { get; set; }
        public DbSet<Pracownik> Pracownik { get; set; }

        // Tworzę "baze" i zapisuję ją jako TPT
        protected override void OnConfiguring(DbContextOptionsBuilder optionBulder)
        {
            optionBulder.UseSqlServer(@"Data Source=DESKTOP-UK1AL1K;Integrated Security=True; Initial Catalog = TPT; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionBulder);
        }
    }
}

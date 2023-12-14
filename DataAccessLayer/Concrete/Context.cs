using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veri tabanı bağlantı adresi
            optionsBuilder.UseSqlServer("server=DESKTOP-AP5G745;database=OtelRezervasyonuDB;integrated security= true;");
        }

        public DbSet<Hakkimizda> HakkimizdaT { get; set; }
        public DbSet<IndexHakkimizda> IndexHakkimizdaT { get; set; }
        public DbSet<Musteri> MusteriT { get; set; }
        public DbSet<Oda> OdaT { get; set; }
        public DbSet<Otel> OtelT { get; set; }
        public DbSet<PopulerOteller> PopulerOtellerT { get; set; }
        public DbSet<Rezervasyon> RezervasyonT { get; set; }
    }
}

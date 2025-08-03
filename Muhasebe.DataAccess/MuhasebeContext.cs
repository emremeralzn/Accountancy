using Microsoft.EntityFrameworkCore;
using Muhasebe.Entities;

namespace Muhasebe.DataAccess
{
    public class MuhasebeContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<FaturaDetay> FaturaDetaylar { get; set; }
        public DbSet<StokHareket> StokHareketler { get; set; }

        public MuhasebeContext(DbContextOptions<MuhasebeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=MuhasebeDB;Trusted_Connection=True;");
            }
        }
    }
}
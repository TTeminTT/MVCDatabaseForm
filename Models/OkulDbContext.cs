using Microsoft.EntityFrameworkCore;
namespace MvcHadi.Models
{
    public class OkulDbContext:DbContext
    {
        string baglanti="Server=AKSA;Database=127.0.0.1;Uid=EminYilmaz;Pwd=123";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(baglanti);
        }
        public DbSet<Ogrenci> Ogrenciler {get;set;}
    }
}
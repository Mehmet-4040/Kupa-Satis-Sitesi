using Microsoft.EntityFrameworkCore;

namespace MyProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Burada tablolara karşılık gelen DbSet'leri tanımlıyoruz
        public DbSet<Urun> Urunler { get; set; }
    }

    public class Urun
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
    }
}

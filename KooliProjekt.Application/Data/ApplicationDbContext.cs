
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Leping> Lepingud { get; set; }
        public DbSet<Autopark> Autopargid { get; set; }
        public DbSet<Tootaja> Tootajad { get; set; }
        public DbSet<Auto> Autod { get; set; }
    }

    public class Leping
    {
        public int Id { get; set; }
        public string Too { get; set; } = string.Empty;
        public decimal Makse { get; set; }
        public string Kirjeldus { get; set; } = string.Empty;
        public decimal Grandtotal { get; set; }
    }

    public class Autopark
    {
        public int Id { get; set; }
        public string Staatus { get; set; } = string.Empty;
        public string Kirjeldus { get; set; } = string.Empty;
        public decimal Toohind { get; set; }
        public string Broneering { get; set; } = string.Empty;
    }

    public class Tootaja
    {
        public int Id { get; set; }
        public string Nimi { get; set; } = string.Empty;
        public string Kasutaja { get; set; } = string.Empty;
        public string Roll { get; set; } = string.Empty;
    }

    public class Auto
    {
        public int Id { get; set; }
        public string Mark { get; set; } = string.Empty;
        public string Mudel { get; set; } = string.Empty;
        public string Registreerimisnumber { get; set; } = string.Empty;
    }
}
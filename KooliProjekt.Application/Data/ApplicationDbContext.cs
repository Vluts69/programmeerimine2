
using Microsoft.EntityFrameworkCore;
using System;
namespace KooliProjekt.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Leping> Lepingud { get; set; }
        public DbSet<Autopark> Autopargid { get; set; }
        public DbSet<Tootaja> Tootajad { get; set; }
        public DbSet<Auto> Autod { get; set; }
    }
 }
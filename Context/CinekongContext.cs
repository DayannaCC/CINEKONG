using Microsoft.EntityFrameworkCore;
using CINEKONG.Models;

namespace CINEKONG.Context
{
    public class CinekongContext : DbContext
    {
        public CinekongContext(DbContextOptions<CinekongContext> dco) : base (dco) {}

     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsuarioButaca>().HasKey(t => new { t.idbut, t.Correo });
           
        }

           
        

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Butaca> Butaca { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using EventManager.Server.Models;

namespace EventManager.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tes tables en base de données
        public DbSet<Event> Events { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Scene> Scenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ici tu pourras configurer des relations spécifiques si besoin
            // Exemple : Un siège appartient à une scène
        }
    }
}
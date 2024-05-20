using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AirlinesSolutions.Models;
using web.Models;

namespace AirlinesSolutions.Data
{
    public class AirlinesContext : IdentityDbContext<ApplicationUser>
    {
        public AirlinesContext(DbContextOptions<AirlinesContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AirlinesSolutions.Models.Flight> Flight { get; set; } = default!;

        public DbSet<AirlinesSolutions.Models.Airport> Airport { get; set; } = default!;

        public DbSet<AirlinesSolutions.Models.Payment> Payment { get; set; } = default!;

        public DbSet<AirlinesSolutions.Models.Invoice> Invoice { get; set; } = default!;
    }
}

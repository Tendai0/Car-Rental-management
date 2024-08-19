using BlazorApp1.Configurations.Entities;
using BlazorApp1.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Model> Models { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ColourSeedConfig());
            modelBuilder.ApplyConfiguration(new RoleSeedConfig());
            modelBuilder.ApplyConfiguration(new MakeSeedConfig());
            modelBuilder.ApplyConfiguration(new ModelSeedConfig()); 
            modelBuilder.ApplyConfiguration(new UserSeedConfig()); 
            modelBuilder.ApplyConfiguration(new UserRoleSeedConfig()); 
        }
    }
}


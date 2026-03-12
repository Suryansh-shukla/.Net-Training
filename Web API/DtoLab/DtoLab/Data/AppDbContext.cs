using Microsoft.EntityFrameworkCore;
using DtoLab.Models;

namespace DtoLab.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed some test data
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "john_doe",
                    Email = "john@example.com",
                    PasswordHash = "hashed_12345",
                    SocialSecurityNumber = "123-45-6789",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    IsAdmin = false,
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new User
                {
                    Id = 2,
                    Username = "jane_admin",
                    Email = "jane@example.com",
                    PasswordHash = "hashed_67890",
                    SocialSecurityNumber = "987-65-4321",
                    DateOfBirth = new DateTime(1985, 10, 22),
                    IsAdmin = true,
                    CreatedAt = new DateTime(2025, 11, 7)
                }
            );
        }
    }
}

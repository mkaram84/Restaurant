using Microsoft.EntityFrameworkCore;

namespace Restaurant.Api.Entities;

public class RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Meal> Meals { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<Configuration> Configurations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships
        modelBuilder.Entity<Menu>()
            .HasMany(m => m.Meals)
            .WithOne(m => m.Menu)
            .HasForeignKey(m => m.MenuID);

        modelBuilder.Entity<Meal>()
            .HasMany(m => m.Ingredients)
            .WithOne(i => i.Meal)
            .HasForeignKey(i => i.MealID);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Employee)
            .WithMany(e => e.Orders)
            .HasForeignKey(o => o.EmployeeID);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Meal)
            .WithMany(m => m.Orders)
            .HasForeignKey(o => o.MealID);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.Employee)
            .WithMany(e => e.Ratings)
            .HasForeignKey(r => r.EmployeeID);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.Meal)
            .WithMany(m => m.Ratings)
            .HasForeignKey(r => r.MealID);

        modelBuilder.Entity<Report>()
            .HasOne(r => r.Admin)
            .WithMany(a => a.Reports)
            .HasForeignKey(r => r.AdminID);

        modelBuilder.Entity<Report>()
            .HasMany(r => r.Orders)
            .WithOne()
            .HasForeignKey(o => o.OrderID);
    }
}

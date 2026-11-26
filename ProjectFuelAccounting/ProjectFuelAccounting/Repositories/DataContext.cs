using Microsoft.EntityFrameworkCore;
using ProjectFuelAccounting.Entities;

namespace ProjectFuelAccounting.Repositories;

public class DataContext : DbContext
{
    public DbSet<Driver> Drivers { get; set; } = null!;
    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Route> Routes { get; set; } = null!;
    public DbSet<Refuel> Refuels { get; set; } = null!;
    public DbSet<Shift> Shifts { get; set; } = null!;
    public DbSet<ShiftRoute> ShiftRoutes { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=FuelAccountingDb;Username=postgres;Password=postgres");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Refuel>()
            .HasOne(r => r.Car)
            .WithMany()
            .HasForeignKey(r => r.CarsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Refuel>()
            .HasOne(r => r.Driver)
            .WithMany()
            .HasForeignKey(r => r.DriversId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Shift>()
            .HasOne(s => s.Driver)
            .WithMany()
            .HasForeignKey(s => s.DriversId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Shift>()
            .HasOne(s => s.Car)
            .WithMany()
            .HasForeignKey(s => s.CarsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ShiftRoute>()
            .HasOne(sr => sr.Shift)
            .WithMany(s => s.ShiftRoutes)
            .HasForeignKey(sr => sr.ShiftsId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ShiftRoute>()
            .HasOne(sr => sr.Route)
            .WithMany()
            .HasForeignKey(sr => sr.RoutesId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
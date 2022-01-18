using Microsoft.EntityFrameworkCore;


namespace Onion.Models
{
    public class SalesContext : DbContext
    {
        internal readonly object Entities;

        public DbSet<Car> Cars {get; set; } 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarColour> CarColours { get; set; }
        public DbSet<CarTypeEngine> CarTypeEngines { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SJA9MS6\SQLEXPRESS;Database=Onion;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne<CarColour>(d => d.CarColours)
                .WithMany(s => s.Car)
                .HasForeignKey(d => d.ColourId);

            modelBuilder.Entity<Car>()
                .HasOne<CarModel>(d => d.CarModels)
                .WithMany(s => s.Car)
                .HasForeignKey(d => d.ModelId);

            modelBuilder.Entity<Car>()
                .HasOne<CarTypeEngine>(d => d.CarTypeEngines)
                .WithMany(s => s.Car)
                .HasForeignKey(d => d.TypeEngineId);

            modelBuilder.Entity<Car>()
                .HasOne<Customer>(d => d.Customers)
                .WithMany(s => s.Car)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}

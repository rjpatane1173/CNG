using Microsoft.EntityFrameworkCore;
using CNGFinder.Models;

namespace CNGFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pump> Pumps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed CNG Pumps
            modelBuilder.Entity<Pump>().HasData(
                new Pump { Id = 1, Name = "HP Petrol & CNG Pump Bhosari Pune", CngAvailable = true, CngPressure = "High", EstimatedWaitTime = 10 },
                new Pump { Id = 2, Name = "Bharat Petroleum CNG Pump, Pimpri", CngAvailable = true, CngPressure = "Moderate", EstimatedWaitTime = 15 },
                new Pump { Id = 3, Name = "Indian Oil CNG Pump, Akurdi", CngAvailable = true, CngPressure = "High", EstimatedWaitTime = 8 },
                new Pump { Id = 4, Name = "HP Gas Station, Nigdi", CngAvailable = true, CngPressure = "Low", EstimatedWaitTime = 20 },
                new Pump { Id = 5, Name = "Shell Petrol & CNG Pump, Chinchwad", CngAvailable = true, CngPressure = "Moderate", EstimatedWaitTime = 12 },
                new Pump { Id = 6, Name = "HP Petrol Pump, Moshi", CngAvailable = false, CngPressure = "N/A", EstimatedWaitTime = 0 },
                new Pump { Id = 7, Name = "Indian Oil Pump, Ravet", CngAvailable = false, CngPressure = "N/A", EstimatedWaitTime = 0 },
                new Pump { Id = 8, Name = "Bharat Petroleum, Chikhali", CngAvailable = false, CngPressure = "N/A", EstimatedWaitTime = 0 },
                new Pump { Id = 9, Name = "Reliance CNG Station, Hinjewadi", CngAvailable = false, CngPressure = "N/A", EstimatedWaitTime = 0 },
                new Pump { Id = 10, Name = "BPCL Gas Pump, Wakad", CngAvailable = false, CngPressure = "N/A", EstimatedWaitTime = 0 }
            );

            // Seed Owners
            modelBuilder.Entity<Owner>().HasData(
                new Owner { Id = 1, Name = "Owner 1", Email = "owner1@example.com", Password = "password1", PumpName = "HP Petrol & CNG Pump Bhosari Pune", Latitude = 18.6359, Longitude = 73.8372 },
                new Owner { Id = 2, Name = "Owner 2", Email = "owner2@example.com", Password = "password2", PumpName = "Bharat Petroleum CNG Pump, Pimpri", Latitude = 18.6262, Longitude = 73.8134 },
                new Owner { Id = 3, Name = "Owner 3", Email = "owner3@example.com", Password = "password3", PumpName = "Indian Oil CNG Pump, Akurdi", Latitude = 18.6441, Longitude = 73.7840 },
                new Owner { Id = 4, Name = "Owner 4", Email = "owner4@example.com", Password = "password4", PumpName = "HP Gas Station, Nigdi", Latitude = 18.6560, Longitude = 73.7716 },
                new Owner { Id = 5, Name = "Owner 5", Email = "owner5@example.com", Password = "password5", PumpName = "Shell Petrol & CNG Pump, Chinchwad", Latitude = 18.6344, Longitude = 73.7722 },
                new Owner { Id = 6, Name = "Owner 6", Email = "owner6@example.com", Password = "password6", PumpName = "HP Petrol Pump, Moshi", Latitude = 18.6675, Longitude = 73.8652 },
                new Owner { Id = 7, Name = "Owner 7", Email = "owner7@example.com", Password = "password7", PumpName = "Indian Oil Pump, Ravet", Latitude = 18.6472, Longitude = 73.7586 },
                new Owner { Id = 8, Name = "Owner 8", Email = "owner8@example.com", Password = "password8", PumpName = "Bharat Petroleum, Chikhali", Latitude = 18.6710, Longitude = 73.8285 },
                new Owner { Id = 9, Name = "Owner 9", Email = "owner9@example.com", Password = "password9", PumpName = "Reliance CNG Station, Hinjewadi", Latitude = 18.5815, Longitude = 73.7388 },
                new Owner { Id = 10, Name = "Owner 10", Email = "owner10@example.com", Password = "password10", PumpName = "BPCL Gas Pump, Wakad", Latitude = 18.5942, Longitude = 73.7620 }
            );

            // Seed Drivers
            modelBuilder.Entity<Driver>().HasData(
                new Driver { Id = 1, Name = "Driver 1", Email = "driver1@example.com", Password = "password1", Phone = "9876543210", CarBrand = "Maruti Suzuki", MaxCapacity = 45 },
                new Driver { Id = 2, Name = "Driver 2", Email = "driver2@example.com", Password = "password2", Phone = "9876543211", CarBrand = "Hyundai", MaxCapacity = 50 },
                new Driver { Id = 3, Name = "Driver 3", Email = "driver3@example.com", Password = "password3", Phone = "9876543212", CarBrand = "Toyota", MaxCapacity = 60 },
                new Driver { Id = 4, Name = "Driver 4", Email = "driver4@example.com", Password = "password4", Phone = "9876543213", CarBrand = "Honda", MaxCapacity = 55 },
                new Driver { Id = 5, Name = "Driver 5", Email = "driver5@example.com", Password = "password5", Phone = "9876543214", CarBrand = "Ford", MaxCapacity = 48 },
                new Driver { Id = 6, Name = "Driver 6", Email = "driver6@example.com", Password = "password6", Phone = "9876543215", CarBrand = "Mahindra", MaxCapacity = 65 },
                new Driver { Id = 7, Name = "Driver 7", Email = "driver7@example.com", Password = "password7", Phone = "9876543216", CarBrand = "Tata", MaxCapacity = 70 },
                new Driver { Id = 8, Name = "Driver 8", Email = "driver8@example.com", Password = "password8", Phone = "9876543217", CarBrand = "Renault", MaxCapacity = 40 },
                new Driver { Id = 9, Name = "Driver 9", Email = "driver9@example.com", Password = "password9", Phone = "9876543218", CarBrand = "Volkswagen", MaxCapacity = 52 },
                new Driver { Id = 10, Name = "Driver 10", Email = "driver10@example.com", Password = "password10", Phone = "9876543219", CarBrand = "Kia", MaxCapacity = 50 }
            );
        }
    }
}

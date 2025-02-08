﻿// <auto-generated />
using CNGFinder.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CNGNavigator.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250208180145_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CNGFinder.Models.Driver", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CarBrand = "Maruti Suzuki",
                            Email = "driver1@example.com",
                            MaxCapacity = 45,
                            Name = "Driver 1",
                            Password = "password1",
                            Phone = "9876543210"
                        },
                        new
                        {
                            Id = 2L,
                            CarBrand = "Hyundai",
                            Email = "driver2@example.com",
                            MaxCapacity = 50,
                            Name = "Driver 2",
                            Password = "password2",
                            Phone = "9876543211"
                        },
                        new
                        {
                            Id = 3L,
                            CarBrand = "Toyota",
                            Email = "driver3@example.com",
                            MaxCapacity = 60,
                            Name = "Driver 3",
                            Password = "password3",
                            Phone = "9876543212"
                        },
                        new
                        {
                            Id = 4L,
                            CarBrand = "Honda",
                            Email = "driver4@example.com",
                            MaxCapacity = 55,
                            Name = "Driver 4",
                            Password = "password4",
                            Phone = "9876543213"
                        },
                        new
                        {
                            Id = 5L,
                            CarBrand = "Ford",
                            Email = "driver5@example.com",
                            MaxCapacity = 48,
                            Name = "Driver 5",
                            Password = "password5",
                            Phone = "9876543214"
                        },
                        new
                        {
                            Id = 6L,
                            CarBrand = "Mahindra",
                            Email = "driver6@example.com",
                            MaxCapacity = 65,
                            Name = "Driver 6",
                            Password = "password6",
                            Phone = "9876543215"
                        },
                        new
                        {
                            Id = 7L,
                            CarBrand = "Tata",
                            Email = "driver7@example.com",
                            MaxCapacity = 70,
                            Name = "Driver 7",
                            Password = "password7",
                            Phone = "9876543216"
                        },
                        new
                        {
                            Id = 8L,
                            CarBrand = "Renault",
                            Email = "driver8@example.com",
                            MaxCapacity = 40,
                            Name = "Driver 8",
                            Password = "password8",
                            Phone = "9876543217"
                        },
                        new
                        {
                            Id = 9L,
                            CarBrand = "Volkswagen",
                            Email = "driver9@example.com",
                            MaxCapacity = 52,
                            Name = "Driver 9",
                            Password = "password9",
                            Phone = "9876543218"
                        },
                        new
                        {
                            Id = 10L,
                            CarBrand = "Kia",
                            Email = "driver10@example.com",
                            MaxCapacity = 50,
                            Name = "Driver 10",
                            Password = "password10",
                            Phone = "9876543219"
                        });
                });

            modelBuilder.Entity("CNGFinder.Models.Owner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PumpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "owner1@example.com",
                            Latitude = 18.635899999999999,
                            Longitude = 73.837199999999996,
                            Name = "Owner 1",
                            Password = "password1",
                            PumpName = "HP Petrol & CNG Pump Bhosari Pune"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "owner2@example.com",
                            Latitude = 18.626200000000001,
                            Longitude = 73.813400000000001,
                            Name = "Owner 2",
                            Password = "password2",
                            PumpName = "Bharat Petroleum CNG Pump, Pimpri"
                        },
                        new
                        {
                            Id = 3L,
                            Email = "owner3@example.com",
                            Latitude = 18.644100000000002,
                            Longitude = 73.784000000000006,
                            Name = "Owner 3",
                            Password = "password3",
                            PumpName = "Indian Oil CNG Pump, Akurdi"
                        },
                        new
                        {
                            Id = 4L,
                            Email = "owner4@example.com",
                            Latitude = 18.655999999999999,
                            Longitude = 73.771600000000007,
                            Name = "Owner 4",
                            Password = "password4",
                            PumpName = "HP Gas Station, Nigdi"
                        },
                        new
                        {
                            Id = 5L,
                            Email = "owner5@example.com",
                            Latitude = 18.634399999999999,
                            Longitude = 73.772199999999998,
                            Name = "Owner 5",
                            Password = "password5",
                            PumpName = "Shell Petrol & CNG Pump, Chinchwad"
                        },
                        new
                        {
                            Id = 6L,
                            Email = "owner6@example.com",
                            Latitude = 18.6675,
                            Longitude = 73.865200000000002,
                            Name = "Owner 6",
                            Password = "password6",
                            PumpName = "HP Petrol Pump, Moshi"
                        },
                        new
                        {
                            Id = 7L,
                            Email = "owner7@example.com",
                            Latitude = 18.647200000000002,
                            Longitude = 73.758600000000001,
                            Name = "Owner 7",
                            Password = "password7",
                            PumpName = "Indian Oil Pump, Ravet"
                        },
                        new
                        {
                            Id = 8L,
                            Email = "owner8@example.com",
                            Latitude = 18.670999999999999,
                            Longitude = 73.828500000000005,
                            Name = "Owner 8",
                            Password = "password8",
                            PumpName = "Bharat Petroleum, Chikhali"
                        },
                        new
                        {
                            Id = 9L,
                            Email = "owner9@example.com",
                            Latitude = 18.581499999999998,
                            Longitude = 73.738799999999998,
                            Name = "Owner 9",
                            Password = "password9",
                            PumpName = "Reliance CNG Station, Hinjewadi"
                        },
                        new
                        {
                            Id = 10L,
                            Email = "owner10@example.com",
                            Latitude = 18.594200000000001,
                            Longitude = 73.762,
                            Name = "Owner 10",
                            Password = "password10",
                            PumpName = "BPCL Gas Pump, Wakad"
                        });
                });

            modelBuilder.Entity("CNGFinder.Models.Pump", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("CngAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("CngPressure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedWaitTime")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pumps");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CngAvailable = true,
                            CngPressure = "High",
                            EstimatedWaitTime = 10,
                            Name = "HP Petrol & CNG Pump Bhosari Pune"
                        },
                        new
                        {
                            Id = 2L,
                            CngAvailable = true,
                            CngPressure = "Moderate",
                            EstimatedWaitTime = 15,
                            Name = "Bharat Petroleum CNG Pump, Pimpri"
                        },
                        new
                        {
                            Id = 3L,
                            CngAvailable = true,
                            CngPressure = "High",
                            EstimatedWaitTime = 8,
                            Name = "Indian Oil CNG Pump, Akurdi"
                        },
                        new
                        {
                            Id = 4L,
                            CngAvailable = true,
                            CngPressure = "Low",
                            EstimatedWaitTime = 20,
                            Name = "HP Gas Station, Nigdi"
                        },
                        new
                        {
                            Id = 5L,
                            CngAvailable = true,
                            CngPressure = "Moderate",
                            EstimatedWaitTime = 12,
                            Name = "Shell Petrol & CNG Pump, Chinchwad"
                        },
                        new
                        {
                            Id = 6L,
                            CngAvailable = false,
                            CngPressure = "N/A",
                            EstimatedWaitTime = 0,
                            Name = "HP Petrol Pump, Moshi"
                        },
                        new
                        {
                            Id = 7L,
                            CngAvailable = false,
                            CngPressure = "N/A",
                            EstimatedWaitTime = 0,
                            Name = "Indian Oil Pump, Ravet"
                        },
                        new
                        {
                            Id = 8L,
                            CngAvailable = false,
                            CngPressure = "N/A",
                            EstimatedWaitTime = 0,
                            Name = "Bharat Petroleum, Chikhali"
                        },
                        new
                        {
                            Id = 9L,
                            CngAvailable = false,
                            CngPressure = "N/A",
                            EstimatedWaitTime = 0,
                            Name = "Reliance CNG Station, Hinjewadi"
                        },
                        new
                        {
                            Id = 10L,
                            CngAvailable = false,
                            CngPressure = "N/A",
                            EstimatedWaitTime = 0,
                            Name = "BPCL Gas Pump, Wakad"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

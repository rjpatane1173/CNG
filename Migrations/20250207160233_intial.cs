using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CNGNavigator.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PumpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pumps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CngAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CngPressure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstimatedWaitTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pumps", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "CarBrand", "Email", "MaxCapacity", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1L, "Maruti Suzuki", "driver1@example.com", 45, "Driver 1", "password1", "9876543210" },
                    { 2L, "Hyundai", "driver2@example.com", 50, "Driver 2", "password2", "9876543211" },
                    { 3L, "Toyota", "driver3@example.com", 60, "Driver 3", "password3", "9876543212" },
                    { 4L, "Honda", "driver4@example.com", 55, "Driver 4", "password4", "9876543213" },
                    { 5L, "Ford", "driver5@example.com", 48, "Driver 5", "password5", "9876543214" },
                    { 6L, "Mahindra", "driver6@example.com", 65, "Driver 6", "password6", "9876543215" },
                    { 7L, "Tata", "driver7@example.com", 70, "Driver 7", "password7", "9876543216" },
                    { 8L, "Renault", "driver8@example.com", 40, "Driver 8", "password8", "9876543217" },
                    { 9L, "Volkswagen", "driver9@example.com", 52, "Driver 9", "password9", "9876543218" },
                    { 10L, "Kia", "driver10@example.com", 50, "Driver 10", "password10", "9876543219" }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Email", "Latitude", "Longitude", "Name", "Password", "PumpName" },
                values: new object[,]
                {
                    { 1L, "owner1@example.com", 18.635899999999999, 73.837199999999996, "Owner 1", "password1", "HP Petrol & CNG Pump Bhosari Pune" },
                    { 2L, "owner2@example.com", 18.626200000000001, 73.813400000000001, "Owner 2", "password2", "Bharat Petroleum CNG Pump, Pimpri" },
                    { 3L, "owner3@example.com", 18.644100000000002, 73.784000000000006, "Owner 3", "password3", "Indian Oil CNG Pump, Akurdi" },
                    { 4L, "owner4@example.com", 18.655999999999999, 73.771600000000007, "Owner 4", "password4", "HP Gas Station, Nigdi" },
                    { 5L, "owner5@example.com", 18.634399999999999, 73.772199999999998, "Owner 5", "password5", "Shell Petrol & CNG Pump, Chinchwad" },
                    { 6L, "owner6@example.com", 18.6675, 73.865200000000002, "Owner 6", "password6", "HP Petrol Pump, Moshi" },
                    { 7L, "owner7@example.com", 18.647200000000002, 73.758600000000001, "Owner 7", "password7", "Indian Oil Pump, Ravet" },
                    { 8L, "owner8@example.com", 18.670999999999999, 73.828500000000005, "Owner 8", "password8", "Bharat Petroleum, Chikhali" },
                    { 9L, "owner9@example.com", 18.581499999999998, 73.738799999999998, "Owner 9", "password9", "Reliance CNG Station, Hinjewadi" },
                    { 10L, "owner10@example.com", 18.594200000000001, 73.762, "Owner 10", "password10", "BPCL Gas Pump, Wakad" }
                });

            migrationBuilder.InsertData(
                table: "Pumps",
                columns: new[] { "Id", "CngAvailable", "CngPressure", "EstimatedWaitTime", "Name" },
                values: new object[,]
                {
                    { 1L, true, "High", 10, "HP Petrol & CNG Pump Bhosari Pune" },
                    { 2L, true, "Moderate", 15, "Bharat Petroleum CNG Pump, Pimpri" },
                    { 3L, true, "High", 8, "Indian Oil CNG Pump, Akurdi" },
                    { 4L, true, "Low", 20, "HP Gas Station, Nigdi" },
                    { 5L, true, "Moderate", 12, "Shell Petrol & CNG Pump, Chinchwad" },
                    { 6L, false, "N/A", 0, "HP Petrol Pump, Moshi" },
                    { 7L, false, "N/A", 0, "Indian Oil Pump, Ravet" },
                    { 8L, false, "N/A", 0, "Bharat Petroleum, Chikhali" },
                    { 9L, false, "N/A", 0, "Reliance CNG Station, Hinjewadi" },
                    { 10L, false, "N/A", 0, "BPCL Gas Pump, Wakad" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Pumps");
        }
    }
}

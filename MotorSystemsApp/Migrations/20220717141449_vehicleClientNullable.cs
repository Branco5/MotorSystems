using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class vehicleClientNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Client",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab605c0b-c11f-43fc-a861-d08b1d19238c", "AQAAAAEAACcQAAAAEB4C6+Io0qIG51cCW9OL/3sqz2B2eEt7UZ9i20hCHdnLVfdlgXU6viZfr1mOKLvD0g==", "2a266fa5-5e48-4766-bcae-49b821d14f7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eeb6af2-1bf8-42af-809e-0ef7aa09cf3f", "AQAAAAEAACcQAAAAEDLYaLZrEnS2RzG0QRAxoeDbyHwJCWjJys1XeDBzYOoSGKdGgUJx9gF0NYXQqkoZeg==", "a21f8b69-4fc0-4523-b43d-eaa86a243d65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e1022d6-7e2c-47cd-bbf4-f9477b1bbaf3", "AQAAAAEAACcQAAAAEDCTKI3xa3Wo2I9yoDKb3SScz3vUdQYGStW4Yfd9ZkPxH4Q4kngybpUF6z8UAsQScg==", "87fa82c6-bc41-44d9-adee-fb9005c6eaf2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Client",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6896ef3-3e0b-44e1-a6bb-f84f6f8008aa", "AQAAAAEAACcQAAAAENyKvS8kHFobR28dKfZ170IRk2tOoh6nbsPM7gVZa2/P90rGvZmwXV4XYfsbc1x6Fg==", "a876db28-a656-4372-9d7c-6d3d1e875f8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51a54a29-f0f5-4985-aeb3-65c23da98a46", "AQAAAAEAACcQAAAAEPvaOrxeGZP9vpmMuf5F9TOtT7nLDYft6cA+uXRgrr/9Ck/Z8yMBrYvfSiQRcgsWdg==", "923d3bfa-e90c-48d1-a1a6-0c44af939b8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd88de53-a2c2-4e5e-814b-240e7b6dc99a", "AQAAAAEAACcQAAAAEK14bltDoEt1vhHd0gzw4K0RX1Bpeggl+pvTehG4rHptxA0b84lLhO+U5zOMABhPIQ==", "31d0f047-75e8-46a2-bf7d-4a81bf125e7e" });
        }
    }
}

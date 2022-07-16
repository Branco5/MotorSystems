using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class deployed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c79bbbf3-146b-44dc-97a9-c5958b668ec7", "AQAAAAEAACcQAAAAEMe2dsefT2VwexjxKQe0HB9s+ANrkdKb1mTAnNyVOkDTOeqtnno2uTDfJH34OVkHNg==", "79cdc1bc-befd-4f5a-9143-e3127b644d1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f153256f-8df1-4984-beb4-f344467a3d18", "AQAAAAEAACcQAAAAEKjoJ9r6kn2wNidKDhkgDmkFPk2UBDfQeBxjJl6o32/DvjsXsxcl9aV/FlQ3P7spSQ==", "44929c80-e42e-40d4-9aed-721fe00c918a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b35e5d0-01e3-4954-8e04-ee8116a12d78", "AQAAAAEAACcQAAAAENOkHtFEuVs6okV21HDuBSE2px67MOa4WuzD/lgT/67oBK/QjGqD/LK8l8TQoMQRFA==", "73ed13c5-6c27-4f98-8eb8-76fc96f3e684" });
        }
    }
}

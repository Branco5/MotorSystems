using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class worker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b94b573d-7e2a-4585-9590-6f6122eda2e3", "AQAAAAEAACcQAAAAEMbs05rCVuuONizho42Aul3nzBrIZZ03BnNIlfGBWuikCOQYoOBnVMdil3Hb+N/Jbw==", "30fba7f1-dc22-486b-b3a4-ebd1cbfda2e8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "CreatedDate", "DocId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[] { "2", 0, "address", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "city", "c0628dc0-22d2-4405-9020-080f16b60268", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "worker@worker.com", true, false, null, "WORKER@WORKER.COM", "WORKER", "AQAAAAEAACcQAAAAEGsroAEfia56J4Klum+B0/A1N/Gg7ymfPI7NTfDt+K+P7NLt2czkZ6eNFzmQdpJECw==", "123456789", false, "d95f43e9-7f22-4ce1-8e80-d0c544e71768", false, "worker", "123" });

            migrationBuilder.InsertData(
                table: "Worker",
                columns: new[] { "Id", "ContractEndDate", "IsAdmin", "JobTitle", "Salary", "Username" },
                values: new object[] { "2", null, false, null, null, "worker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Worker",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38232b49-b4a0-472b-82af-e41435edeb54", "AQAAAAEAACcQAAAAEM5QUOlyf+mkN6V8jSZk7q5ZC3ueTekOid+o+Ko7W+tahXGhJOFyMu5xUJYIWOFdSg==", "e4ed1de2-344f-4af4-b4a3-d24cf4285f4d" });
        }
    }
}

﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d977b456-fe8a-4735-8d81-66a90078b5ad", "AQAAAAEAACcQAAAAEAKCYwtCvPzxc/x5LPHV2/aJxUHNm89Jz+lJoIDGG9QG0VP3h6BdQXSQUI1OQgHPAQ==", "6683fc49-b34f-4169-8544-79aae540cf14" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "CreatedDate", "DocId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[] { "3", 0, "address", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "city", "9e46643f-2681-482b-8467-22e0898be496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "client1@client1.com", true, false, null, "CLIENT1@CLIENT1.COM", "CLIENT1", null, "123456789", false, "964bbd8d-7922-4d40-a904-935ad6bb570b", false, "client1", "123" });

            migrationBuilder.UpdateData(
                table: "Worker",
                keyColumn: "Id",
                keyValue: "2",
                column: "Username",
                value: "worker1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

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

            migrationBuilder.UpdateData(
                table: "Worker",
                keyColumn: "Id",
                keyValue: "2",
                column: "Username",
                value: "worker");
        }
    }
}

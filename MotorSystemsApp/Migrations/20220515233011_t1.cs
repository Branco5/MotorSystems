using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class t1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c2a2db6-26f8-41ab-8a23-49085fbea7d8", "AQAAAAEAACcQAAAAEEnt9CHDQx4rzRKxFy7DvPn5QHoPrYogEiNl9SWyeXegXktEAu/zwH4igU5ETW9R1g==", "ffc3d31f-0e66-43b9-b5ee-622946aacef4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f4d4dc3-3460-445e-928b-f89a4ccd0386", "2cc3d5dc-7662-406d-a9e6-c3995d4dad3f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "City", "ConcurrencyStamp", "CreatedDate", "DocId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Zip" },
                values: new object[] { "2", 0, "address", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "city", "02003770-2060-4f50-9cbc-35f6f917419c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "worker1@worker1.com", true, false, null, "WORKER1@WORKER1.COM", "WORKER1", "AQAAAAEAACcQAAAAEHCbd4m1IrSfyXJ6OmZub3nwosI8gERcRQ83clUKp3ev7z8RsQKSzr/ewnE//sPinA==", "123456789", false, "739ee140-1ac6-49ea-8c39-86be545e5810", false, "worker1", "123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "590777dd-49fc-4209-ae2b-900da1747a5f", "AQAAAAEAACcQAAAAEFQLDPBRoS6CoiIfgyYUeri9SefpHFHOuELdr/zFtrqUT8hM1g7eSFJsXZ/JaXpY0g==", "4127d6fa-4411-45f9-aef3-b36b87946596" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "807f202f-9917-4f9d-a319-7dc3ed3c751b", "7a753bc7-27e1-460e-ae99-51f12992cb9b" });
        }
    }
}

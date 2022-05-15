using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class t2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "712627f9-1649-4d9d-acaf-84eacfe63d9c", "AQAAAAEAACcQAAAAEHmz7FeBG2zKB0xl35aLZUGPQY8DHvtEZ5LsEWLMfNYAJcAbavVrvG61++G2c6rDhg==", "cb2187df-ad61-4bb3-9c9c-54bfabaaa4b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1949b55b-294d-4b6f-b20f-0a81b419d782", "AQAAAAEAACcQAAAAEKtgsQgRGXRLaMojl7ksx+J7QC4+qINCgG2KyoVKUsujTlBCPdLGU1NpvIqVm/3uTw==", "005d7f06-d644-4740-91c7-d5feaf4b3e78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9392741-478b-494d-a437-a1ab87125066", "AQAAAAEAACcQAAAAEJDMw07KdaoW3yMGNdx9MjK2CM9wLp6UhnfEHA9q4VJ5IyjBZCjPgdGvUPBBwJ3x5g==", "dabde750-c925-4238-af71-cabefb75b9eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02003770-2060-4f50-9cbc-35f6f917419c", "AQAAAAEAACcQAAAAEHCbd4m1IrSfyXJ6OmZub3nwosI8gERcRQ83clUKp3ev7z8RsQKSzr/ewnE//sPinA==", "739ee140-1ac6-49ea-8c39-86be545e5810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f4d4dc3-3460-445e-928b-f89a4ccd0386", null, "2cc3d5dc-7662-406d-a9e6-c3995d4dad3f" });
        }
    }
}

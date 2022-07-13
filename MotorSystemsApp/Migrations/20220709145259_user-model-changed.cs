using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class usermodelchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ServiceUpdated",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2de20c10-73c9-46af-9afd-b3a990edcdde", "AQAAAAEAACcQAAAAEHdP9nzN5IAQtbdMlMcLg6BU2IWII55AKg/1C4pkCefrRkiUmtTcJKjwGjtXV9napg==", "1ddeb2da-b18b-4513-834f-e6a9e968ec27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9558b1cf-d1a1-423c-b9d4-72b4f183332c", "AQAAAAEAACcQAAAAELs9HzzHPzAYnCTaf0pVJi027sv7bhiif03Wy4tu3QkMHV/8J8zamz2cQ3zQfYsfYw==", "41db9840-023d-4de5-9612-8b965acaeb93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c92fc28-286a-48e3-bee0-f6d9cd0f1ba7", "AQAAAAEAACcQAAAAEIlww0W0h3emoPEqMRlra/Lx7WJfkPKBYlHxhxMDR/acyvfdmOfWTr1k3GQgFgzQPQ==", "c69d4e30-16ec-4711-af70-2ab644909c67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceUpdated",
                table: "AspNetUsers");

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
    }
}

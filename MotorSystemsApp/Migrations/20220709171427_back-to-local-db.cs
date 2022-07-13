using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class backtolocaldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

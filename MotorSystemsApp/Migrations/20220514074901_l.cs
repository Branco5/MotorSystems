using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class l : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38232b49-b4a0-472b-82af-e41435edeb54", "AQAAAAEAACcQAAAAEM5QUOlyf+mkN6V8jSZk7q5ZC3ueTekOid+o+Ko7W+tahXGhJOFyMu5xUJYIWOFdSg==", "e4ed1de2-344f-4af4-b4a3-d24cf4285f4d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "769b0864-aaed-4909-8dd4-267b6968530c", "AQAAAAEAACcQAAAAEBkfFNsa+l5e8X4EM5OAiKWifwc7Yyh3u2S0CM0azMYBr3+RTKhH0mK7PPuoQW+HZg==", "e094399e-707c-4afc-aed1-0683da1de8ff" });
        }
    }
}

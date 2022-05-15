using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorSystemsApp.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d977b456-fe8a-4735-8d81-66a90078b5ad", "AQAAAAEAACcQAAAAEAKCYwtCvPzxc/x5LPHV2/aJxUHNm89Jz+lJoIDGG9QG0VP3h6BdQXSQUI1OQgHPAQ==", "6683fc49-b34f-4169-8544-79aae540cf14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e46643f-2681-482b-8467-22e0898be496", "964bbd8d-7922-4d40-a904-935ad6bb570b" });
        }
    }
}

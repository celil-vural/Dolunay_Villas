using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRoomsNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cda8788-ae59-47b3-8604-b31262c07f68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d81c2ecb-527f-4663-9419-f387ebfbc9b8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6638342b-9bf1-408e-9e18-e6ec222cc6ab", "404995c9-c7c5-4e12-8a6f-fd85bb415b46", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b474cd5-d51b-438f-91c4-6ae277fc8abb", "a804ca04-c7a9-4f84-8592-65d865bc1ef5", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6638342b-9bf1-408e-9e18-e6ec222cc6ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b474cd5-d51b-438f-91c4-6ae277fc8abb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cda8788-ae59-47b3-8604-b31262c07f68", "275b417d-b9c9-4f15-9879-20445a989efd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d81c2ecb-527f-4663-9419-f387ebfbc9b8", "b4d457a8-6459-4c82-b29b-bc257df65a8e", "Admin", "ADMIN" });
        }
    }
}

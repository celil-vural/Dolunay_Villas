using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14db627a-5557-453b-9a6e-b1e8e6bf3fee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d08e3e23-84d7-48ad-acbf-ef26545fb89c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e9d6604-22d1-42f4-9465-e07a5881d4a4", "4daf28c3-67b5-48fe-b277-bab6ecca32ea", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4d82fa2-033c-4737-971d-e96caf089ecf", "f49f254d-811e-431b-af1b-a81d6f49c803", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9d6604-22d1-42f4-9465-e07a5881d4a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4d82fa2-033c-4737-971d-e96caf089ecf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14db627a-5557-453b-9a6e-b1e8e6bf3fee", "7fabf74e-cf66-4cd7-9ed3-d276a5db1ff2", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d08e3e23-84d7-48ad-acbf-ef26545fb89c", "6847d044-2d58-4cf5-ad81-fda914693cdd", "Admin", "ADMIN" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class newPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49e48148-36b6-4a16-ab8e-845323cde928");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd759417-4ca8-4e45-920c-8149f5e05d8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46bdafd8-f618-4158-900f-9acc687d5909", "7864d7ba-91b0-4ea3-b99e-fc4ddd58c0f8", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b0e0de-401b-4f72-9ed9-0f0a520aee1c", "26f17f2b-92aa-4574-908c-54488709144d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46bdafd8-f618-4158-900f-9acc687d5909");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b0e0de-401b-4f72-9ed9-0f0a520aee1c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49e48148-36b6-4a16-ab8e-845323cde928", "6028bce1-6692-4213-b57d-8a374ccba709", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd759417-4ca8-4e45-920c-8149f5e05d8d", "3526aade-39b7-4f66-ba63-c225a9acd805", "Editor", "EDITOR" });
        }
    }
}

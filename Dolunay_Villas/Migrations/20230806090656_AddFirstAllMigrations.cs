using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddFirstAllMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ecb447c-9ce6-4f22-af3f-eaec4c931d80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65c6692-a9fc-4c48-84af-960a9f5d1ee0");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Rules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUser",
                table: "Rules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "HeatingOptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUser",
                table: "HeatingOptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "006b8315-9155-4f8a-80e3-b9c294f98bab", "bbff5b81-ccff-4681-96fc-1ce29df93213", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbf2be82-dcc0-46f8-ab98-b1f2fcd9343b", "dc1b73ba-36a1-49af-82a5-6fbe723597c3", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "006b8315-9155-4f8a-80e3-b9c294f98bab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf2be82-dcc0-46f8-ab98-b1f2fcd9343b");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Rules");

            migrationBuilder.DropColumn(
                name: "UpdatedByUser",
                table: "Rules");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "HeatingOptions");

            migrationBuilder.DropColumn(
                name: "UpdatedByUser",
                table: "HeatingOptions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ecb447c-9ce6-4f22-af3f-eaec4c931d80", "fb185f1e-0b73-481b-b642-833537e4cc26", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e65c6692-a9fc-4c48-84af-960a9f5d1ee0", "78f77e34-ffc7-4c77-82ff-d17474d3ecf8", "Admin", "ADMIN" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddMigrations23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a131e4-f0a8-42f2-8deb-c8b931fcde25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fde6d236-c097-49b0-972f-9e5077ad475a");

            migrationBuilder.RenameColumn(
                name: "Rule_Title_Tr",
                table: "HeatingOptions",
                newName: "Heating_Options_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Rule_Title_En",
                table: "HeatingOptions",
                newName: "Heating_Options_Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4ecb447c-9ce6-4f22-af3f-eaec4c931d80", "fb185f1e-0b73-481b-b642-833537e4cc26", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e65c6692-a9fc-4c48-84af-960a9f5d1ee0", "78f77e34-ffc7-4c77-82ff-d17474d3ecf8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ecb447c-9ce6-4f22-af3f-eaec4c931d80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65c6692-a9fc-4c48-84af-960a9f5d1ee0");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_Tr",
                table: "HeatingOptions",
                newName: "Rule_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_En",
                table: "HeatingOptions",
                newName: "Rule_Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94a131e4-f0a8-42f2-8deb-c8b931fcde25", "f764284c-7433-4f12-b4d5-5c2e66f7476d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fde6d236-c097-49b0-972f-9e5077ad475a", "562f2ae3-e5db-46e8-9b42-1a81c5675079", "Editor", "EDITOR" });
        }
    }
}

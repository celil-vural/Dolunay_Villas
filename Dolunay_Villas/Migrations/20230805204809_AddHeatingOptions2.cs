using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddHeatingOptions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c29e04d-267f-45ce-b798-1077be95a710");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc1ea2b-d92c-496a-9292-956bcc9dc0e3");

            migrationBuilder.CreateTable(
                name: "HeatingOptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rule_Title_Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rule_Title_En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeatingOptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94a131e4-f0a8-42f2-8deb-c8b931fcde25", "f764284c-7433-4f12-b4d5-5c2e66f7476d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fde6d236-c097-49b0-972f-9e5077ad475a", "562f2ae3-e5db-46e8-9b42-1a81c5675079", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeatingOptions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94a131e4-f0a8-42f2-8deb-c8b931fcde25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fde6d236-c097-49b0-972f-9e5077ad475a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c29e04d-267f-45ce-b798-1077be95a710", "bd6464b7-f0ab-426b-953f-3e85e7330e06", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbc1ea2b-d92c-496a-9292-956bcc9dc0e3", "92d69554-e514-4f07-b603-40236d23bc3d", "Admin", "ADMIN" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRoomFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "006b8315-9155-4f8a-80e3-b9c294f98bab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbf2be82-dcc0-46f8-ab98-b1f2fcd9343b");

            migrationBuilder.CreateTable(
                name: "RoomFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Heating_Options_Title_Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Heating_Options_Title_En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomFeatures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5763dd00-9bfc-4f62-822d-be8026feb72c", "f33bfc28-5dce-4d21-af19-a38c4b87f5db", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3c7a861-448e-493a-82c2-50981208f8af", "193a3d6e-45ef-4442-b6eb-f1be822727ba", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomFeatures");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5763dd00-9bfc-4f62-822d-be8026feb72c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3c7a861-448e-493a-82c2-50981208f8af");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "006b8315-9155-4f8a-80e3-b9c294f98bab", "bbff5b81-ccff-4681-96fc-1ce29df93213", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbf2be82-dcc0-46f8-ab98-b1f2fcd9343b", "dc1b73ba-36a1-49af-82a5-6fbe723597c3", "Editor", "EDITOR" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddHighlights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71049519-b93c-4ca4-8b82-d80f979d5734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a96350-a3b5-4390-83dc-10dff0e574e9");

            migrationBuilder.CreateTable(
                name: "Highlights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Highlights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13aae919-f3bc-4f8d-a1cf-98647ce09b49", "30db690f-a7db-4e2d-b9cb-4603cdd6eaea", "Admin", "ADMIN" },
                    { "ad63a9de-cd8b-4564-b847-1d2efe6379f5", "a30e71da-1e8a-4541-a4c0-2369178040af", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1118), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1131), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1132), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1133), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1135), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1256), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1259), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1260), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1261), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1262), new DateTime(2023, 8, 7, 22, 55, 39, 527, DateTimeKind.Local).AddTicks(1263) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Highlights");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13aae919-f3bc-4f8d-a1cf-98647ce09b49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad63a9de-cd8b-4564-b847-1d2efe6379f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71049519-b93c-4ca4-8b82-d80f979d5734", "6deb53b6-6544-4166-8f33-406f5e4a2020", "Admin", "ADMIN" },
                    { "80a96350-a3b5-4390-83dc-10dff0e574e9", "2e4eed36-8396-4d1e-b936-18cfc8392eec", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3571), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3585), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3586) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3587), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3589), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3590), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3762), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3768), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3770), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3771), new DateTime(2023, 8, 6, 23, 22, 26, 294, DateTimeKind.Local).AddTicks(3771) });
        }
    }
}

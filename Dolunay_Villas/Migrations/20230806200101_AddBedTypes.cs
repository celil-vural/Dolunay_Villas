using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddBedTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94f07ccc-5731-4a90-815a-26c20f3c3ea4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8c5d64d-4048-4a5c-b6c9-70325539ecb5");

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValueTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BedTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title_En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemTypesId = table.Column<int>(type: "int", nullable: false),
                    ValueTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BedTypes_ItemTypes_ItemTypesId",
                        column: x => x.ItemTypesId,
                        principalTable: "ItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedTypes_ValueTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "ValueTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbb6f0dd-673a-425d-957a-915168b4dd49", "6d57e36e-84ed-43dc-81f2-c35e80242a99", "Admin", "ADMIN" },
                    { "ff6ef6a7-f42d-415a-a784-25a948a42dba", "5cec49fd-015c-4f94-852c-9441f2f4e0f2", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedByUser", "Name", "UpdatedAt", "UpdatedByUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8488), "", "Structural Product", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8496), "" },
                    { 2, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8502), "", "Built-in Furniture", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8502), "" },
                    { 3, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8503), "", "Electronic Product", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8503), "" },
                    { 4, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8504), "", "Bed", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8504), "" },
                    { 5, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8505), "", "Furniture", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8505), "" },
                    { 6, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8506), "", "Floor", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8506), "" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedByUser", "Name", "UpdatedAt", "UpdatedByUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8599), "", "Yes/No", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8600), "" },
                    { 2, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8602), "", "Letter", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8602), "" },
                    { 3, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8603), "", "Numeric", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8603), "" },
                    { 4, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8604), "", "Multiple Selection", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8604), "" },
                    { 5, new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8605), "", "One choice", new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8605), "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedTypes_ItemTypesId",
                table: "BedTypes",
                column: "ItemTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_BedTypes_ValueTypeId",
                table: "BedTypes",
                column: "ValueTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedTypes");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb6f0dd-673a-425d-957a-915168b4dd49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff6ef6a7-f42d-415a-a784-25a948a42dba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "94f07ccc-5731-4a90-815a-26c20f3c3ea4", "b90f0382-ba29-4ab1-a9e7-a8d69c0f49cf", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8c5d64d-4048-4a5c-b6c9-70325539ecb5", "986dc024-3cf4-4632-b980-0f1450aca990", "Admin", "ADMIN" });
        }
    }
}

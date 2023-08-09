using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRegions2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Regions_ParentRegionID",
                table: "Regions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f2b5313-39c0-48e2-a7b4-f67e0526a9ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b9366dd-5d46-4144-ac79-e9f25408de82");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8dae6127-b221-43ce-893d-07f29288acf4", "ec42f200-3bce-4a54-9259-d4ea667186f4", "Editor", "EDITOR" },
                    { "db77e21e-1a15-41bf-a34b-7fb05932c049", "2ea14ffb-4af9-49f3-9aa1-876f7916da51", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9746), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9764), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9766), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9767), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9768), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9768) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9769), new DateTime(2023, 8, 9, 22, 25, 38, 119, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1554), new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1559), new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1560), new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1604), new DateTime(2023, 8, 9, 22, 25, 38, 120, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Regions_ParentRegionID",
                table: "Regions",
                column: "ParentRegionID",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Regions_ParentRegionID",
                table: "Regions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dae6127-b221-43ce-893d-07f29288acf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db77e21e-1a15-41bf-a34b-7fb05932c049");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f2b5313-39c0-48e2-a7b4-f67e0526a9ad", "41d774c4-2405-4f6c-ab1d-c9d38211d85d", "Editor", "EDITOR" },
                    { "4b9366dd-5d46-4144-ac79-e9f25408de82", "f35d10e3-8b28-42c1-b1a4-0ccab7d71ba1", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4955), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4956), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4959), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7746), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7749), new DateTime(2023, 8, 9, 22, 24, 34, 919, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Regions_ParentRegionID",
                table: "Regions",
                column: "ParentRegionID",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

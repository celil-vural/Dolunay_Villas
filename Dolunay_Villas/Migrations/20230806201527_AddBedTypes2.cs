using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddBedTypes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[,]
                {
                    { "69790c7e-171a-46fa-8138-6b860f3d2b28", "48e7f10c-2129-4b60-8109-36b415b03fe0", "Admin", "ADMIN" },
                    { "c75a8d8c-2814-4efc-bcae-f12926660220", "678faf4a-3a35-442f-bbb5-14f45144c021", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(361) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(364), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(470), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(475), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(477), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(478), new DateTime(2023, 8, 6, 23, 15, 27, 617, DateTimeKind.Local).AddTicks(479) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69790c7e-171a-46fa-8138-6b860f3d2b28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c75a8d8c-2814-4efc-bcae-f12926660220");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbb6f0dd-673a-425d-957a-915168b4dd49", "6d57e36e-84ed-43dc-81f2-c35e80242a99", "Admin", "ADMIN" },
                    { "ff6ef6a7-f42d-415a-a784-25a948a42dba", "5cec49fd-015c-4f94-852c-9441f2f4e0f2", "Editor", "EDITOR" }
                });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8488), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8502), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8505), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "ItemTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8599), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 8, 6, 23, 1, 1, 148, DateTimeKind.Local).AddTicks(8605) });
        }
    }
}

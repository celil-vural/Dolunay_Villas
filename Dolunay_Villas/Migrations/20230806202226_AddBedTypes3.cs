using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddBedTypes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedTypes_ItemTypes_ItemTypesId",
                table: "BedTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_BedTypes_ValueTypes_ValueTypeId",
                table: "BedTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69790c7e-171a-46fa-8138-6b860f3d2b28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c75a8d8c-2814-4efc-bcae-f12926660220");

            migrationBuilder.AlterColumn<int>(
                name: "ValueTypeId",
                table: "BedTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemTypesId",
                table: "BedTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeKey",
                table: "BedTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ValueTypeKey",
                table: "BedTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BedTypes_ItemTypes_ItemTypesId",
                table: "BedTypes",
                column: "ItemTypesId",
                principalTable: "ItemTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BedTypes_ValueTypes_ValueTypeId",
                table: "BedTypes",
                column: "ValueTypeId",
                principalTable: "ValueTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedTypes_ItemTypes_ItemTypesId",
                table: "BedTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_BedTypes_ValueTypes_ValueTypeId",
                table: "BedTypes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71049519-b93c-4ca4-8b82-d80f979d5734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a96350-a3b5-4390-83dc-10dff0e574e9");

            migrationBuilder.DropColumn(
                name: "ItemTypeKey",
                table: "BedTypes");

            migrationBuilder.DropColumn(
                name: "ValueTypeKey",
                table: "BedTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ValueTypeId",
                table: "BedTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemTypesId",
                table: "BedTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BedTypes_ItemTypes_ItemTypesId",
                table: "BedTypes",
                column: "ItemTypesId",
                principalTable: "ItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BedTypes_ValueTypes_ValueTypeId",
                table: "BedTypes",
                column: "ValueTypeId",
                principalTable: "ValueTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

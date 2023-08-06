using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddHeatingOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9d6604-22d1-42f4-9465-e07a5881d4a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4d82fa2-033c-4737-971d-e96caf089ecf");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Rules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Rules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3c29e04d-267f-45ce-b798-1077be95a710", "bd6464b7-f0ab-426b-953f-3e85e7330e06", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dbc1ea2b-d92c-496a-9292-956bcc9dc0e3", "92d69554-e514-4f07-b603-40236d23bc3d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c29e04d-267f-45ce-b798-1077be95a710");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbc1ea2b-d92c-496a-9292-956bcc9dc0e3");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Rules");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Rules");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e9d6604-22d1-42f4-9465-e07a5881d4a4", "4daf28c3-67b5-48fe-b277-bab6ecca32ea", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4d82fa2-033c-4737-971d-e96caf089ecf", "f49f254d-811e-431b-af1b-a81d6f49c803", "Editor", "EDITOR" });
        }
    }
}

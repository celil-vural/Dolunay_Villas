using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRoomFeaturesTableNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "2ae0617b-41b2-4fd3-9b03-c7d1457c6583", "020bd078-f62a-465e-9b24-a9e496644111", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e82203b-3611-47f1-bcb1-135a7c889868", "5abbde05-8b05-4a7e-b161-cbd3c5cc79b6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ae0617b-41b2-4fd3-9b03-c7d1457c6583");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e82203b-3611-47f1-bcb1-135a7c889868");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5763dd00-9bfc-4f62-822d-be8026feb72c", "f33bfc28-5dce-4d21-af19-a38c4b87f5db", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3c7a861-448e-493a-82c2-50981208f8af", "193a3d6e-45ef-4442-b6eb-f1be822727ba", "Editor", "EDITOR" });
        }
    }
}

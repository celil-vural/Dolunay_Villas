using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRoomFeaturesTableNew1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ae0617b-41b2-4fd3-9b03-c7d1457c6583");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e82203b-3611-47f1-bcb1-135a7c889868");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_Tr",
                table: "RoomFeatures",
                newName: "Room_Features_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_En",
                table: "RoomFeatures",
                newName: "Room_Features_Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "297befe7-5fc2-4f08-ad76-9ea97a030a49", "541b6f43-9fe0-464c-a23e-bce06962638c", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3a0f2b4-8e58-4476-8b40-e4ee385a9d96", "afe476f8-b83e-4d9c-bd81-42af4c9515d1", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "297befe7-5fc2-4f08-ad76-9ea97a030a49");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3a0f2b4-8e58-4476-8b40-e4ee385a9d96");

            migrationBuilder.RenameColumn(
                name: "Room_Features_Title_Tr",
                table: "RoomFeatures",
                newName: "Heating_Options_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Room_Features_Title_En",
                table: "RoomFeatures",
                newName: "Heating_Options_Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2ae0617b-41b2-4fd3-9b03-c7d1457c6583", "020bd078-f62a-465e-9b24-a9e496644111", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e82203b-3611-47f1-bcb1-135a7c889868", "5abbde05-8b05-4a7e-b161-cbd3c5cc79b6", "Admin", "ADMIN" });
        }
    }
}

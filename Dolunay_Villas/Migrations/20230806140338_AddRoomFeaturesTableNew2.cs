using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRoomFeaturesTableNew2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Rule_Title_Tr",
                table: "Rules",
                newName: "Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Rule_Title_En",
                table: "Rules",
                newName: "Title_En");

            migrationBuilder.RenameColumn(
                name: "Room_Features_Title_Tr",
                table: "RoomFeatures",
                newName: "Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Room_Features_Title_En",
                table: "RoomFeatures",
                newName: "Title_En");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_Tr",
                table: "HeatingOptions",
                newName: "Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Heating_Options_Title_En",
                table: "HeatingOptions",
                newName: "Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7cda8788-ae59-47b3-8604-b31262c07f68", "275b417d-b9c9-4f15-9879-20445a989efd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d81c2ecb-527f-4663-9419-f387ebfbc9b8", "b4d457a8-6459-4c82-b29b-bc257df65a8e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cda8788-ae59-47b3-8604-b31262c07f68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d81c2ecb-527f-4663-9419-f387ebfbc9b8");

            migrationBuilder.RenameColumn(
                name: "Title_Tr",
                table: "Rules",
                newName: "Rule_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Title_En",
                table: "Rules",
                newName: "Rule_Title_En");

            migrationBuilder.RenameColumn(
                name: "Title_Tr",
                table: "RoomFeatures",
                newName: "Room_Features_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Title_En",
                table: "RoomFeatures",
                newName: "Room_Features_Title_En");

            migrationBuilder.RenameColumn(
                name: "Title_Tr",
                table: "HeatingOptions",
                newName: "Heating_Options_Title_Tr");

            migrationBuilder.RenameColumn(
                name: "Title_En",
                table: "HeatingOptions",
                newName: "Heating_Options_Title_En");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "297befe7-5fc2-4f08-ad76-9ea97a030a49", "541b6f43-9fe0-464c-a23e-bce06962638c", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3a0f2b4-8e58-4476-8b40-e4ee385a9d96", "afe476f8-b83e-4d9c-bd81-42af4c9515d1", "Admin", "ADMIN" });
        }
    }
}

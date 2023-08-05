using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dolunay_Villas.Migrations
{
    public partial class AddRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46bdafd8-f618-4158-900f-9acc687d5909");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1b0e0de-401b-4f72-9ed9-0f0a520aee1c");

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rule_Title_Tr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rule_Title_En = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconString = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "14db627a-5557-453b-9a6e-b1e8e6bf3fee", "7fabf74e-cf66-4cd7-9ed3-d276a5db1ff2", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d08e3e23-84d7-48ad-acbf-ef26545fb89c", "6847d044-2d58-4cf5-ad81-fda914693cdd", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14db627a-5557-453b-9a6e-b1e8e6bf3fee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d08e3e23-84d7-48ad-acbf-ef26545fb89c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46bdafd8-f618-4158-900f-9acc687d5909", "7864d7ba-91b0-4ea3-b99e-fc4ddd58c0f8", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1b0e0de-401b-4f72-9ed9-0f0a520aee1c", "26f17f2b-92aa-4574-908c-54488709144d", "Admin", "ADMIN" });
        }
    }
}

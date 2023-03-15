using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "17451fb8-0ee2-4ca0-8a2a-778acfb69785");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f678b367-fe4e-4a43-a85a-f93947311363");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0a1f26e-2af6-411c-87a5-bfc8aba25aea", "AQAAAAEAACcQAAAAELfm6HctmDBjuh7lZGuWWVlZ+8vvcwzFmKa77COVZaNYQxxlbwUshLyIldGfCFd+lQ==", "5912b0b4-67ee-4b25-9784-89d5d1601d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8362b3f-9dd3-4d21-ba75-89566a4429ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45c7f197-ba17-4ce4-9dc9-869763cce752", "AQAAAAEAACcQAAAAEEf9BfSLpg6oIFNnVCqI83DHOmH63aXj2IPm4oANFZxg0CSlGBL5AtGkbPa0LTIyrg==", "f0cc09cd-2df8-48c1-9578-f80f203651a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a0d4e80d-52a4-4c61-8fa9-75f29e9e58e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "51cfdac1-2fae-40c5-80e6-79f239d4a307");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13ea4fc1-c05c-429c-965e-09f0e442f03f", "AQAAAAEAACcQAAAAEPH/nvAYPgcA7hlNe6rSiDN3qUa6H8ScogJLho/52JCtiOTOyMJCtSWyPOZG5g3fFA==", "29cb1c68-f331-4a9f-ba7b-b6bf4e15621d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8362b3f-9dd3-4d21-ba75-89566a4429ce",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b194f26-6f56-437f-b300-2122c19a0cf5", "AQAAAAEAACcQAAAAEHYDWwCLfqMv28M3g3oQ53ZDMlDO7KzK8jgH7SbYrSdIhc/BMucVko1CiYrNQhYd3Q==", "9c2bde1e-fc48-4ee7-8230-f310d0f75a38" });
        }
    }
}

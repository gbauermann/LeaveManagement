using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class added_default_users_and_roles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasttName",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd413ccbbf",
                column: "ConcurrencyStamp",
                value: "2f7d7daa-176f-43d1-b679-1bbbbe224042");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7bb-cc48-baaf-41dd413cc123",
                column: "ConcurrencyStamp",
                value: "241659fb-0d4c-4b43-863e-7e9adb423e41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cc4e6e-a8bb-4448-baaf-ladd413abcfd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "75ddf984-83d6-4a1a-8e02-8e7aa64e5624", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEGRNx7X+vVT7lj/tP0okE06p4VCSuIvEKRuUww+aanG6RrnEbcfgkJN2DB1qLwue9g==", "dbcde2a6-b2a5-46c6-a9b1-a2ee4ddca421", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48aa3a6e-a8bb-4448-baaf-ladd413bcabe",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "821c149b-b399-4f69-aa87-5b1c5d47d39e", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBHPt0DJTKWfUhkZ0XI6k11BqWJIMRk+FEBfLtCr6xxB4B1vdBzmSDQMKu38yEJoLQ==", "268f342e-1bf0-4738-ad5b-897541037a79", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LasttName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd413ccbbf",
                column: "ConcurrencyStamp",
                value: "26e4622c-cae2-4258-8abc-bc0630d967dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7bb-cc48-baaf-41dd413cc123",
                column: "ConcurrencyStamp",
                value: "6ba003dd-59d4-40d1-9dbd-c0f91e95f01c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cc4e6e-a8bb-4448-baaf-ladd413abcfd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9fae9fc8-5261-47b6-b577-7fc6a572e6d3", false, null, "AQAAAAEAACcQAAAAEBEDBulrrsDll+FlGUBOF2gd3H/Z2tt4uq7GJ1hsbL7LvY7OhQCKLeleCq+cCH8YSA==", "4d4bcd4f-fa3a-4ff0-b1b3-a1013ee717bd", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48aa3a6e-a8bb-4448-baaf-ladd413bcabe",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c224388-c6dc-404f-b240-1d15dc7a1e14", false, null, "AQAAAAEAACcQAAAAEN0t2Vryz+mmwUcduFT9b7VUZIPyBUlBYSPUyu+1wre30O4LXS0bHILQD0IU3Ci0WQ==", "1b8426d9-34d9-456e-aa3f-86796940427d", null });
        }
    }
}

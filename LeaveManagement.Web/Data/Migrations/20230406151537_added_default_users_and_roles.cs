using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class added_default_users_and_roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-ladd413ccbbf", "26e4622c-cae2-4258-8abc-bc0630d967dd", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7bb-cc48-baaf-41dd413cc123", "6ba003dd-59d4-40d1-9dbd-c0f91e95f01c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LasttName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32cc4e6e-a8bb-4448-baaf-ladd413abcfd", 0, "9fae9fc8-5261-47b6-b577-7fc6a572e6d3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEBEDBulrrsDll+FlGUBOF2gd3H/Z2tt4uq7GJ1hsbL7LvY7OhQCKLeleCq+cCH8YSA==", null, false, "4d4bcd4f-fa3a-4ff0-b1b3-a1013ee717bd", null, false, null },
                    { "48aa3a6e-a8bb-4448-baaf-ladd413bcabe", 0, "8c224388-c6dc-404f-b240-1d15dc7a1e14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEN0t2Vryz+mmwUcduFT9b7VUZIPyBUlBYSPUyu+1wre30O4LXS0bHILQD0IU3Ci0WQ==", null, false, "1b8426d9-34d9-456e-aa3f-86796940427d", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7bb-cc48-baaf-41dd413cc123", "32cc4e6e-a8bb-4448-baaf-ladd413abcfd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-ladd413ccbbf", "48aa3a6e-a8bb-4448-baaf-ladd413bcabe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7bb-cc48-baaf-41dd413cc123", "32cc4e6e-a8bb-4448-baaf-ladd413abcfd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-ladd413ccbbf", "48aa3a6e-a8bb-4448-baaf-ladd413bcabe" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd413ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7bb-cc48-baaf-41dd413cc123");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cc4e6e-a8bb-4448-baaf-ladd413abcfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48aa3a6e-a8bb-4448-baaf-ladd413bcabe");
        }
    }
}

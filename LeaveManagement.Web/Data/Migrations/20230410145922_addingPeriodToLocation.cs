using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addingPeriodToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd413ccbbf",
                column: "ConcurrencyStamp",
                value: "3533dd71-9da9-4a40-a158-513ad82000d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7bb-cc48-baaf-41dd413cc123",
                column: "ConcurrencyStamp",
                value: "ba5df9a5-b54d-4928-808f-d1ad62994f32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cc4e6e-a8bb-4448-baaf-ladd413abcfd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2b3723a-4c99-4295-8e59-4125caca34ed", "AQAAAAEAACcQAAAAENsE6sZn4LPrx6zm+RQ4LoWbj8aZxK3zOqpnwXAHfIj9Yjf72yNXbIw1Khh/U2L/Jg==", "681871c5-4a54-4d3f-9b30-3f53a72c5fb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48aa3a6e-a8bb-4448-baaf-ladd413bcabe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84fea6ff-8d42-4cd5-920b-d0fd87582707", "AQAAAAEAACcQAAAAEOCRoulccSO56rvJMPHAFr2T+FaTB+C7ouW56Nl/Y4SrHGGctOStQ9U1/xLiFLhXBg==", "c81f2e3f-cf4f-40ab-a5d6-b60dbec820eb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75ddf984-83d6-4a1a-8e02-8e7aa64e5624", "AQAAAAEAACcQAAAAEGRNx7X+vVT7lj/tP0okE06p4VCSuIvEKRuUww+aanG6RrnEbcfgkJN2DB1qLwue9g==", "dbcde2a6-b2a5-46c6-a9b1-a2ee4ddca421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48aa3a6e-a8bb-4448-baaf-ladd413bcabe",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "821c149b-b399-4f69-aa87-5b1c5d47d39e", "AQAAAAEAACcQAAAAEBHPt0DJTKWfUhkZ0XI6k11BqWJIMRk+FEBfLtCr6xxB4B1vdBzmSDQMKu38yEJoLQ==", "268f342e-1bf0-4738-ad5b-897541037a79" });
        }
    }
}

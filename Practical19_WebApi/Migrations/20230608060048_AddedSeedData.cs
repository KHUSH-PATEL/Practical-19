using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practical19_WebApi.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2d87252-64d3-44d8-8613-8556bd227596", "b2d87252-64d3-44d8-8613-8556bd227596", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fb27675d-572e-4070-9af9-6add730f2c72", 0, "6d70f9dd-238b-402a-990d-6689826b2ae6", "admin@gmail.com", false, "Admin", "Karan", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK7yYX7qp+yC7blD9DNZqX6HMzncqetU1YlGHowJGLyaf/y09vGFFW7z/zi+QDDuEA==", null, false, "f500fa53-c1d4-4d89-8ce2-38ad2a0bf173", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2d87252-64d3-44d8-8613-8556bd227596", "fb27675d-572e-4070-9af9-6add730f2c72" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2d87252-64d3-44d8-8613-8556bd227596", "fb27675d-572e-4070-9af9-6add730f2c72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2d87252-64d3-44d8-8613-8556bd227596");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb27675d-572e-4070-9af9-6add730f2c72");
        }
    }
}

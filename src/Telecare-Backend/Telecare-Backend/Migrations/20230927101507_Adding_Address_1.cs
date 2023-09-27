using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Address_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "AspNetUsers",
                newName: "GenDer");

            migrationBuilder.AlterColumn<string>(
                name: "PresentAddress",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ParmanentAdress",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GenDer", "IsDeactivate", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RelationShipStatus", "UserName" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "893ebd6f-54ff-4d3e-a73b-eac3a9aa09a0", "mdsojibhosen444@gmail.com", true, "Md Sojib", "Male", false, "Khan", null, null, "dhsgdwe323", "01778553706", false, "Single", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.RenameColumn(
                name: "GenDer",
                table: "AspNetUsers",
                newName: "Gender");

            migrationBuilder.AlterColumn<Guid>(
                name: "PresentAddress",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParmanentAdress",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Address_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb89"),
                column: "ConcurrencyStamp",
                value: "397af2fa-902b-46fd-88b9-d5574a53a61e");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb89"),
                column: "ConcurrencyStamp",
                value: "ea1bfc20-f162-480e-bd8c-52e41f7c7203");
        }
    }
}

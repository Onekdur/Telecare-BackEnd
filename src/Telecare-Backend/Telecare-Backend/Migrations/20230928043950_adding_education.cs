using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_education : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("8c99c516-e901-42c9-8b78-deda48ac0813"));

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    EnducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CureentlyRunnig = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.EnducationId);
                    table.ForeignKey(
                        name: "FK_Education_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("fa2e169c-800c-458e-b175-014648494c7c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "1271f904-93d0-4445-a3a6-e8d79039e010");

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("1e66b440-90cd-46fb-b34d-b658fe93f0ad"), false, "BA", null, new DateTime(2023, 9, 28, 4, 39, 50, 384, DateTimeKind.Utc).AddTicks(2856), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 10, 39, 50, 384, DateTimeKind.Local).AddTicks(2857) },
                    { new Guid("79fff40f-f38f-473b-a833-1b54287d67c7"), false, "Bsc", null, new DateTime(2023, 9, 28, 4, 39, 50, 384, DateTimeKind.Utc).AddTicks(2826), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 10, 39, 50, 384, DateTimeKind.Local).AddTicks(2830) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_MemberId",
                table: "Education",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("fa2e169c-800c-458e-b175-014648494c7c"));

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("8c99c516-e901-42c9-8b78-deda48ac0813"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "aa192ff3-f534-4c43-8d7b-9d76909dd71b");
        }
    }
}

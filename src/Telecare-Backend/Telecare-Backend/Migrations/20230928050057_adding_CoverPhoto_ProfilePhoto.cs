using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_CoverPhoto_ProfilePhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("fa2e169c-800c-458e-b175-014648494c7c"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("1e66b440-90cd-46fb-b34d-b658fe93f0ad"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("79fff40f-f38f-473b-a833-1b54287d67c7"));

            migrationBuilder.CreateTable(
                name: "CoverPhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverPhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ispresent = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverPhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoverPhoto_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePhoto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    profilePhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePhoto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePhoto_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("4b7757b8-736d-494d-905f-f2a02e4327c8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "24964988-5cfb-4949-82c9-22deff52ef2b");

            migrationBuilder.InsertData(
                table: "CoverPhoto",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("4c7adc07-5bd7-4bf3-894d-0d0674420536"), "www.aws.com", true, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("e59396b4-b968-438f-9799-2461c300e515"), "www.colud.com", true, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("844774b3-13c6-4611-824f-4e7ebde6ea7d"), false, "Bsc", null, new DateTime(2023, 9, 28, 5, 0, 57, 511, DateTimeKind.Utc).AddTicks(6174), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 11, 0, 57, 511, DateTimeKind.Local).AddTicks(6180) },
                    { new Guid("f640c2b5-8b61-4833-add5-91b2c139cf16"), false, "BA", null, new DateTime(2023, 9, 28, 5, 0, 57, 511, DateTimeKind.Utc).AddTicks(6204), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 11, 0, 57, 511, DateTimeKind.Local).AddTicks(6204) }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhoto",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("00c7a41a-15e7-4552-bcc6-8bc71f1a8b4f"), true, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("20c2bbb6-b97f-42f7-86e2-e6f02e87947d"), true, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoverPhoto_MemberId",
                table: "CoverPhoto",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePhoto_MemberId",
                table: "ProfilePhoto",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoverPhoto");

            migrationBuilder.DropTable(
                name: "ProfilePhoto");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("4b7757b8-736d-494d-905f-f2a02e4327c8"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("844774b3-13c6-4611-824f-4e7ebde6ea7d"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("f640c2b5-8b61-4833-add5-91b2c139cf16"));

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Work : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("4b7757b8-736d-494d-905f-f2a02e4327c8"));

            migrationBuilder.DeleteData(
                table: "CoverPhoto",
                keyColumn: "Id",
                keyValue: new Guid("4c7adc07-5bd7-4bf3-894d-0d0674420536"));

            migrationBuilder.DeleteData(
                table: "CoverPhoto",
                keyColumn: "Id",
                keyValue: new Guid("e59396b4-b968-438f-9799-2461c300e515"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("844774b3-13c6-4611-824f-4e7ebde6ea7d"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("f640c2b5-8b61-4833-add5-91b2c139cf16"));

            migrationBuilder.DeleteData(
                table: "ProfilePhoto",
                keyColumn: "Id",
                keyValue: new Guid("00c7a41a-15e7-4552-bcc6-8bc71f1a8b4f"));

            migrationBuilder.DeleteData(
                table: "ProfilePhoto",
                keyColumn: "Id",
                keyValue: new Guid("20c2bbb6-b97f-42f7-86e2-e6f02e87947d"));

            migrationBuilder.CreateTable(
                name: "Work",
                columns: table => new
                {
                    WorkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComapnyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentlyRunning = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work", x => x.WorkId);
                    table.ForeignKey(
                        name: "FK_Work_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("c472792b-6c89-4373-baf0-d4f9d62a0d93"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "ae089917-3be8-4134-83f7-286167d01ca4");

            migrationBuilder.InsertData(
                table: "CoverPhoto",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("1de56fe0-983e-4b30-a53c-b5e7924a4d03"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("3fda9983-9047-434f-9070-7b0c09d90c34"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("5aebc241-5fc1-4cb8-ad59-63a6a3e259fc"), false, "BA", null, new DateTime(2023, 9, 28, 5, 10, 27, 872, DateTimeKind.Utc).AddTicks(7663), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 11, 10, 27, 872, DateTimeKind.Local).AddTicks(7664) },
                    { new Guid("e69f1749-2d18-4606-9d79-4a278f8164fe"), false, "Bsc", null, new DateTime(2023, 9, 28, 5, 10, 27, 872, DateTimeKind.Utc).AddTicks(7638), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 11, 10, 27, 872, DateTimeKind.Local).AddTicks(7642) }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhoto",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("1e6e43e4-1ca8-4a45-8916-9cd5aef66845"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("927f6d79-55da-4758-8e5d-6135b294c8e4"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "Work",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("5cca2ca7-6232-4ac3-80dc-a72c7ca3db92"), "Vivasoft", false, null, new DateTime(2023, 9, 28, 11, 10, 27, 872, DateTimeKind.Local).AddTicks(9008), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 17, 10, 27, 872, DateTimeKind.Local).AddTicks(9009) },
                    { new Guid("9a31bd0a-3fd7-4d76-b015-43cb9d10370e"), "Devskill", false, null, new DateTime(2023, 9, 28, 11, 10, 27, 872, DateTimeKind.Local).AddTicks(8994), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 7, 10, 27, 872, DateTimeKind.Local).AddTicks(8996) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Work_MemberId",
                table: "Work",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Work");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "AddressID",
                keyValue: new Guid("c472792b-6c89-4373-baf0-d4f9d62a0d93"));

            migrationBuilder.DeleteData(
                table: "CoverPhoto",
                keyColumn: "Id",
                keyValue: new Guid("1de56fe0-983e-4b30-a53c-b5e7924a4d03"));

            migrationBuilder.DeleteData(
                table: "CoverPhoto",
                keyColumn: "Id",
                keyValue: new Guid("3fda9983-9047-434f-9070-7b0c09d90c34"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("5aebc241-5fc1-4cb8-ad59-63a6a3e259fc"));

            migrationBuilder.DeleteData(
                table: "Education",
                keyColumn: "EnducationId",
                keyValue: new Guid("e69f1749-2d18-4606-9d79-4a278f8164fe"));

            migrationBuilder.DeleteData(
                table: "ProfilePhoto",
                keyColumn: "Id",
                keyValue: new Guid("1e6e43e4-1ca8-4a45-8916-9cd5aef66845"));

            migrationBuilder.DeleteData(
                table: "ProfilePhoto",
                keyColumn: "Id",
                keyValue: new Guid("927f6d79-55da-4758-8e5d-6135b294c8e4"));

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
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_SendingRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("7623ee2f-87d7-4a70-964e-828410d6393e"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5ffd02eb-c1d0-4f4b-ac3b-2f3b12c52818"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("881a3d67-d43e-4769-8b97-724b6e0ee34d"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("7534e9d5-5dc7-49f6-aaf7-fa6389e070a5"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("cd6f2275-2200-4187-9c4a-5e9d45953aec"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "FriendRequestId",
                keyValue: new Guid("12e7789d-7ef4-4385-a7ae-e0e9c0b62fe9"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("72a86e30-e29d-40b6-b430-ab62127855f8"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("b58958b8-140a-43ee-a137-1481d73d5c01"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("4f6def4a-a32c-47bb-b479-36dc79ed0fea"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("de034850-e4d7-46a4-977a-4f858cf4cb01"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("7713c096-8a7d-410f-98e3-87eced0ca0eb"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("a9428349-57b3-4765-be2d-f2626a098dce"));

            migrationBuilder.CreateTable(
                name: "SendingRequests",
                columns: table => new
                {
                    SendingRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SendFriendRequestUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendingRequests", x => x.SendingRequestId);
                    table.ForeignKey(
                        name: "FK_SendingRequests_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("43cc2462-7ec5-4335-bafd-3e7dabae069c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "2d4330a7-db6f-498d-a858-4700d4be1042");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("ba24f976-bf22-4942-8724-8ac9447cf66d"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ba8e1769-335d-4295-be56-3d0c98ab167a"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("58e504c4-1a03-4545-963f-94fd8b495800"), false, "BA", null, new DateTime(2023, 9, 28, 9, 43, 35, 933, DateTimeKind.Utc).AddTicks(1584), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 15, 43, 35, 933, DateTimeKind.Local).AddTicks(1585) },
                    { new Guid("e9e376bb-ad7f-490d-9e73-661cb7a41c57"), false, "Bsc", null, new DateTime(2023, 9, 28, 9, 43, 35, 933, DateTimeKind.Utc).AddTicks(1554), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 15, 43, 35, 933, DateTimeKind.Local).AddTicks(1562) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "FriendRequestId", "IsSeen", "MemberId", "RequestUserID" },
                values: new object[] { new Guid("cdb98222-311c-489e-b1d1-4d90ac42b8b2"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("6ef494bd-39b2-47b4-9896-3d973629ceac") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("60f77b8d-f1e8-429a-bf85-63c7428d3cd5"), false, false, false, new Guid("fcda9b08-8711-4fcd-b91b-b37081f46e9a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("cc121da1-f3f6-42ec-86d8-c69c81cb2434"), false, false, false, new Guid("f86fbc8d-e000-4b68-8f1d-2483c9428a41"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("00b5df78-78ee-4017-ab84-3c6fc03f0808"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("7f28a657-6f56-49a9-bf58-383ff29d303b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "SendingRequestId", "MemberId", "SendFriendRequestUserID" },
                values: new object[] { new Guid("8bec0267-eb8e-485e-8add-a6e84d3b3134"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("f5c92456-3056-4f8a-afb0-cda73c67fcd5") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("8da5f114-7138-40c1-a451-ac294740e18f"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 15, 43, 35, 933, DateTimeKind.Local).AddTicks(2664), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 21, 43, 35, 933, DateTimeKind.Local).AddTicks(2664) },
                    { new Guid("b1263a64-c18e-4570-82fb-45b598e218e6"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 15, 43, 35, 933, DateTimeKind.Local).AddTicks(2652), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 11, 43, 35, 933, DateTimeKind.Local).AddTicks(2654) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SendingRequests_MemberId",
                table: "SendingRequests",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SendingRequests");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("43cc2462-7ec5-4335-bafd-3e7dabae069c"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ba24f976-bf22-4942-8724-8ac9447cf66d"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ba8e1769-335d-4295-be56-3d0c98ab167a"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("58e504c4-1a03-4545-963f-94fd8b495800"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("e9e376bb-ad7f-490d-9e73-661cb7a41c57"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "FriendRequestId",
                keyValue: new Guid("cdb98222-311c-489e-b1d1-4d90ac42b8b2"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("60f77b8d-f1e8-429a-bf85-63c7428d3cd5"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("cc121da1-f3f6-42ec-86d8-c69c81cb2434"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("00b5df78-78ee-4017-ab84-3c6fc03f0808"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("7f28a657-6f56-49a9-bf58-383ff29d303b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("8da5f114-7138-40c1-a451-ac294740e18f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("b1263a64-c18e-4570-82fb-45b598e218e6"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("7623ee2f-87d7-4a70-964e-828410d6393e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "0bb65a50-9d16-4aaf-8d6f-bacfd8116852");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("5ffd02eb-c1d0-4f4b-ac3b-2f3b12c52818"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("881a3d67-d43e-4769-8b97-724b6e0ee34d"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("7534e9d5-5dc7-49f6-aaf7-fa6389e070a5"), false, "BA", null, new DateTime(2023, 9, 28, 9, 13, 32, 33, DateTimeKind.Utc).AddTicks(6504), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 15, 13, 32, 33, DateTimeKind.Local).AddTicks(6505) },
                    { new Guid("cd6f2275-2200-4187-9c4a-5e9d45953aec"), false, "Bsc", null, new DateTime(2023, 9, 28, 9, 13, 32, 33, DateTimeKind.Utc).AddTicks(6471), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 15, 13, 32, 33, DateTimeKind.Local).AddTicks(6483) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "FriendRequestId", "IsSeen", "MemberId", "RequestUserID" },
                values: new object[] { new Guid("12e7789d-7ef4-4385-a7ae-e0e9c0b62fe9"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("7350b4bc-0eb9-4bb1-ac09-bfeee49965dd") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("72a86e30-e29d-40b6-b430-ab62127855f8"), false, false, false, new Guid("d3d73994-543a-4439-902c-e6dd4af70b52"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("b58958b8-140a-43ee-a137-1481d73d5c01"), false, false, false, new Guid("0b7a77cf-78a6-438d-bb16-f02d07bd8dcc"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("4f6def4a-a32c-47bb-b479-36dc79ed0fea"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("de034850-e4d7-46a4-977a-4f858cf4cb01"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("7713c096-8a7d-410f-98e3-87eced0ca0eb"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 15, 13, 32, 33, DateTimeKind.Local).AddTicks(7409), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 21, 13, 32, 33, DateTimeKind.Local).AddTicks(7410) },
                    { new Guid("a9428349-57b3-4765-be2d-f2626a098dce"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 15, 13, 32, 33, DateTimeKind.Local).AddTicks(7399), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 11, 13, 32, 33, DateTimeKind.Local).AddTicks(7400) }
                });
        }
    }
}

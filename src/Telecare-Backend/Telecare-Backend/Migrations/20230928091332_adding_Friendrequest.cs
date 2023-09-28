using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Friendrequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("3bdd6706-98e4-4459-8516-2699d2ca3fe2"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8ec0f560-dbf3-4acd-9fa1-3f18942952d0"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("da8fde5c-bc35-4844-9656-d7bf04a62bae"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("7870e399-240d-4f30-999f-56eead9a63d6"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("f69ae2ed-4552-4b98-aa10-fb7c3e25a823"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("7d741dbb-b8e9-4319-a75f-9871f54c254a"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("988102f3-f78a-4231-aa68-f63d4fd273b0"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("78fe3ce9-e185-4973-aa8b-138c0bcbe3ce"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("7d48d4f1-09af-4429-b1ef-481f69d7fc79"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("43a95f53-bf07-45af-bd6c-65786188d72b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("cb981417-5f24-4561-bb36-eacf8a239a52"));

            migrationBuilder.CreateTable(
                name: "FriendRequests",
                columns: table => new
                {
                    FriendRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendRequests", x => x.FriendRequestId);
                    table.ForeignKey(
                        name: "FK_FriendRequests_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequests_MemberId",
                table: "FriendRequests",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendRequests");

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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("3bdd6706-98e4-4459-8516-2699d2ca3fe2"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "94e2bede-60c0-4652-bca4-a254c63033c2");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("8ec0f560-dbf3-4acd-9fa1-3f18942952d0"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("da8fde5c-bc35-4844-9656-d7bf04a62bae"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("7870e399-240d-4f30-999f-56eead9a63d6"), false, "BA", null, new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8493), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8494) },
                    { new Guid("f69ae2ed-4552-4b98-aa10-fb7c3e25a823"), false, "Bsc", null, new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8466), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8470) }
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("7d741dbb-b8e9-4319-a75f-9871f54c254a"), false, false, false, new Guid("f8c26f33-64f3-44d4-97ae-9d04a1f33f25"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("988102f3-f78a-4231-aa68-f63d4fd273b0"), false, false, false, new Guid("188d4bbf-2b26-451f-acbc-00b244d0ddd9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("78fe3ce9-e185-4973-aa8b-138c0bcbe3ce"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("7d48d4f1-09af-4429-b1ef-481f69d7fc79"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("43a95f53-bf07-45af-bd6c-65786188d72b"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9313), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 9, 15, 56, 182, DateTimeKind.Local).AddTicks(9314) },
                    { new Guid("cb981417-5f24-4561-bb36-eacf8a239a52"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9328), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 19, 15, 56, 182, DateTimeKind.Local).AddTicks(9329) }
                });
        }
    }
}

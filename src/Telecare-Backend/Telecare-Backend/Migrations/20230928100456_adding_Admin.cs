using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "SendingRequests",
                keyColumn: "SendingRequestId",
                keyValue: new Guid("8bec0267-eb8e-485e-8add-a6e84d3b3134"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("8da5f114-7138-40c1-a451-ac294740e18f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("b1263a64-c18e-4570-82fb-45b598e218e6"));

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CEO = table.Column<bool>(type: "bit", nullable: false),
                    SuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    GeneralAdmin = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("781072e9-20d7-4c84-b9fb-236d2e470a28"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("1454c0bc-7c94-46ae-b274-a01e5d468c11"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "4f3e798d-c812-42b2-9c3a-ff47a43b32b1");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("5533f68d-eb7f-4a54-8a52-87c05b99ca56"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("c66ec511-20c4-464f-88e7-37601c62b242"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("61e59055-f984-4742-a00d-11cd4674bd52"), false, "Bsc", null, new DateTime(2023, 9, 28, 10, 4, 56, 496, DateTimeKind.Utc).AddTicks(8197), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 16, 4, 56, 496, DateTimeKind.Local).AddTicks(8205) },
                    { new Guid("9bfcdd1c-cbae-432f-92a0-5236f713e7b5"), false, "BA", null, new DateTime(2023, 9, 28, 10, 4, 56, 496, DateTimeKind.Utc).AddTicks(8228), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 16, 4, 56, 496, DateTimeKind.Local).AddTicks(8228) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "FriendRequestId", "IsSeen", "MemberId", "RequestUserID" },
                values: new object[] { new Guid("7cc8614f-2173-49f2-8f51-f2c16c55f63c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("5868ee53-dfef-46b0-92eb-b4edf225b740") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("3ee26e77-934a-4c25-9840-696464bbbd38"), false, false, false, new Guid("1d51d914-cc53-4ff8-bf29-22ddc9b2ed68"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("741b54e5-4c98-4b93-941c-578d35c0bf4a"), false, false, false, new Guid("b3954c1d-d701-499d-8a3f-603d0f03105c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3115fbba-1876-4f5f-9a39-20127d83f2c6"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("9c2b8e52-1404-4247-acb3-85dc4d3e7053"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "SendingRequestId", "MemberId", "SendFriendRequestUserID" },
                values: new object[] { new Guid("6d71308a-803b-4761-8c31-73bb4405c824"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("c7ceb19b-a467-4b48-9f84-203493b2cca7") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("c9dafcf1-5201-483c-b135-051ec1ad1635"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 16, 4, 56, 496, DateTimeKind.Local).AddTicks(9301), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 22, 4, 56, 496, DateTimeKind.Local).AddTicks(9302) },
                    { new Guid("e07a7bcd-f589-4d9a-bea2-13ae93a0aced"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 16, 4, 56, 496, DateTimeKind.Local).AddTicks(9289), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 12, 4, 56, 496, DateTimeKind.Local).AddTicks(9292) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_MemberId",
                table: "Admins",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("781072e9-20d7-4c84-b9fb-236d2e470a28"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5533f68d-eb7f-4a54-8a52-87c05b99ca56"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("c66ec511-20c4-464f-88e7-37601c62b242"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("61e59055-f984-4742-a00d-11cd4674bd52"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("9bfcdd1c-cbae-432f-92a0-5236f713e7b5"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "FriendRequestId",
                keyValue: new Guid("7cc8614f-2173-49f2-8f51-f2c16c55f63c"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("3ee26e77-934a-4c25-9840-696464bbbd38"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("741b54e5-4c98-4b93-941c-578d35c0bf4a"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3115fbba-1876-4f5f-9a39-20127d83f2c6"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("9c2b8e52-1404-4247-acb3-85dc4d3e7053"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "SendingRequestId",
                keyValue: new Guid("6d71308a-803b-4761-8c31-73bb4405c824"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("c9dafcf1-5201-483c-b135-051ec1ad1635"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("e07a7bcd-f589-4d9a-bea2-13ae93a0aced"));

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
        }
    }
}

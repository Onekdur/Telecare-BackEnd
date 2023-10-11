using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Photo_Like : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b5037567-857e-425c-acda-1ed1453df7fe"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("5416ed65-f768-4d15-b87c-821afa5c368e"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("12055a35-3d61-4212-b96a-cf7dfe56018b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6a1ff212-6c24-4a12-bfa8-ecc4ae057995"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("e17a34fb-d50f-40a9-b059-28695feab85f"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("90cbc9a7-91fa-41ec-a199-0b1a4b6b1fea"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("f5d0bff6-67a1-4167-97e2-0921ccc52239"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("1e4ec300-8d14-4707-93ea-5092ae7d10ee"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6722965b-16e7-4c57-828d-e354171ec214"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6d8035f7-f870-4614-8235-c79e9497ba74"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("7f2f7d64-754c-4cd7-a39b-9c0470bb1e28"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("2dd37c87-8ff5-4b1b-a310-1d7f7d174999"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("c3940e7d-3c5a-456d-8f71-10e16a259206"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("691fec75-47c7-405b-b9f0-81b3dca3ec67"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("63eb860b-2fde-4b64-8870-aa795ad26ae8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f53c694b-050c-42a3-8b18-7d389ed240ae"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("05a0088a-8f0e-4dc2-a0d9-4ba8abd6b281"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("43fe52bd-caf3-4662-8f93-67f1da3113b8"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("326f3e96-6d39-47e9-b80e-2e3eafdfd364"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5ba02c76-2044-42d2-88e6-615109dc5d7e"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d00c531f-5958-4e78-a088-8db0557ae230"));

            migrationBuilder.CreateTable(
                name: "PhotoLikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    React = table.Column<int>(type: "int", nullable: false),
                    MemmberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoLikes_AspNetUsers_MemmberId",
                        column: x => x.MemmberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotoLikes_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("114470e1-9332-4993-a94a-580617e544c1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("e65af569-441c-49d4-a522-189a0b2982ca"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "0791c6c8-cc15-46e7-a328-8b189ddf5b30");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("8a7481d1-29f8-474e-a020-c066c224a4fe"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("f09772ca-ea2c-4ac3-bc1f-12ece886aba7"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("ce1b2056-b2ca-43a1-9ccd-cb7c0a939050"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 6, 9, 29, 37, 197, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("2979e858-6870-489f-a9be-80ba082e0384"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("861c541f-acf1-4579-91f1-4a561420acdf"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("ad395ed1-90ec-4c4e-86a5-8a80749307e9"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("6f3bd658-5ac3-4f69-880f-8e4c7fa3c08d"), false, "BA", null, null, new DateTime(2023, 10, 6, 9, 29, 37, 195, DateTimeKind.Utc).AddTicks(874), null, "Rajshahi University", new DateTime(2028, 10, 6, 15, 29, 37, 195, DateTimeKind.Local).AddTicks(875), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("ff2c14a7-c5c5-42ae-aa13-fa4e6e8f0a16"), false, "Bsc", null, null, new DateTime(2023, 10, 6, 9, 29, 37, 195, DateTimeKind.Utc).AddTicks(847), null, "Islamic University", new DateTime(2028, 10, 6, 15, 29, 37, 195, DateTimeKind.Local).AddTicks(851), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("d33e8f86-0d09-45a8-95f1-46309f845a8c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("d20308b5-7dd8-4f6f-a042-926dc2685757") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("80fbe0ea-91ef-4a06-8ad7-443b95d7a733"), false, false, false, new Guid("b41d710b-6906-4855-9ab7-4c8646eb04e7"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("a19e2600-da4a-4f1e-a356-54e246060c13"), false, false, false, new Guid("e38f86fb-616e-4b17-b9eb-f7f8a853223e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("4d9ddc08-3500-4373-b200-d8687fd9dde6"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PhotLink", "PostId" },
                values: new object[] { new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), "www.aws.com", new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"),
                column: "Time",
                value: new DateTime(2023, 10, 6, 15, 29, 37, 197, DateTimeKind.Local).AddTicks(7986));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[] { new Guid("6ef413ba-089c-4388-bd58-5d4286375e17"), "Good morning friens", new DateTime(2023, 10, 6, 15, 29, 37, 197, DateTimeKind.Local).AddTicks(7997), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("604e0a99-41e8-4033-b5a7-f668064b9b9d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("a596c65d-5275-4949-9689-3fedc63b8c1b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("9b4091dc-6e4f-4dbe-a437-72ef57351fc6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("fc3a4865-e6cf-4ac1-afaa-b69bec250a13") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("3eb01c9b-f7bd-401a-992b-9afa72f0c172"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 6, 15, 29, 37, 195, DateTimeKind.Local).AddTicks(1733), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 7, 11, 29, 37, 195, DateTimeKind.Local).AddTicks(1735), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("aff8004a-b3e3-4eb1-9421-9a3cb57426ad"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 6, 15, 29, 37, 195, DateTimeKind.Local).AddTicks(1747), false, false, null, " Software Enginer", new DateTime(2023, 10, 7, 21, 29, 37, 195, DateTimeKind.Local).AddTicks(1747), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "PhotoLikes",
                columns: new[] { "Id", "MemmberId", "PhotoId", "React" },
                values: new object[] { new Guid("bfb55932-1648-41ea-831e-91ae622c12ad"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoLikes_MemmberId",
                table: "PhotoLikes",
                column: "MemmberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoLikes_PhotoId",
                table: "PhotoLikes",
                column: "PhotoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoLikes");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("114470e1-9332-4993-a94a-580617e544c1"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e65af569-441c-49d4-a522-189a0b2982ca"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8a7481d1-29f8-474e-a020-c066c224a4fe"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f09772ca-ea2c-4ac3-bc1f-12ece886aba7"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("ce1b2056-b2ca-43a1-9ccd-cb7c0a939050"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("2979e858-6870-489f-a9be-80ba082e0384"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("861c541f-acf1-4579-91f1-4a561420acdf"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("ad395ed1-90ec-4c4e-86a5-8a80749307e9"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6f3bd658-5ac3-4f69-880f-8e4c7fa3c08d"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ff2c14a7-c5c5-42ae-aa13-fa4e6e8f0a16"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("d33e8f86-0d09-45a8-95f1-46309f845a8c"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("80fbe0ea-91ef-4a06-8ad7-443b95d7a733"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("a19e2600-da4a-4f1e-a356-54e246060c13"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("4d9ddc08-3500-4373-b200-d8687fd9dde6"));

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6ef413ba-089c-4388-bd58-5d4286375e17"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("604e0a99-41e8-4033-b5a7-f668064b9b9d"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("a596c65d-5275-4949-9689-3fedc63b8c1b"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("9b4091dc-6e4f-4dbe-a437-72ef57351fc6"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3eb01c9b-f7bd-401a-992b-9afa72f0c172"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("aff8004a-b3e3-4eb1-9421-9a3cb57426ad"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("b5037567-857e-425c-acda-1ed1453df7fe"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("5416ed65-f768-4d15-b87c-821afa5c368e"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "b6f864be-fdbe-43e5-bfe4-0db5899bc677");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("12055a35-3d61-4212-b96a-cf7dfe56018b"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("6a1ff212-6c24-4a12-bfa8-ecc4ae057995"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("e17a34fb-d50f-40a9-b059-28695feab85f"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 6, 7, 5, 6, 81, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("90cbc9a7-91fa-41ec-a199-0b1a4b6b1fea"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("f5d0bff6-67a1-4167-97e2-0921ccc52239"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("1e4ec300-8d14-4707-93ea-5092ae7d10ee"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("6722965b-16e7-4c57-828d-e354171ec214"), false, "Bsc", null, null, new DateTime(2023, 10, 6, 7, 5, 6, 79, DateTimeKind.Utc).AddTicks(4602), null, "Islamic University", new DateTime(2028, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(4606), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("6d8035f7-f870-4614-8235-c79e9497ba74"), false, "BA", null, null, new DateTime(2023, 10, 6, 7, 5, 6, 79, DateTimeKind.Utc).AddTicks(4629), null, "Rajshahi University", new DateTime(2028, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(4630), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("7f2f7d64-754c-4cd7-a39b-9c0470bb1e28"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("b7a2a3f0-2a08-433c-94ae-e5d8cf36449a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("2dd37c87-8ff5-4b1b-a310-1d7f7d174999"), false, false, false, new Guid("5cffdbc0-7748-4e5f-9655-52263659a9a1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("c3940e7d-3c5a-456d-8f71-10e16a259206"), false, false, false, new Guid("92a91119-434f-454e-95de-ccbc2077fa89"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("691fec75-47c7-405b-b9f0-81b3dca3ec67"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PhotLink", "PostId" },
                values: new object[] { new Guid("63eb860b-2fde-4b64-8870-aa795ad26ae8"), "www.aws.com", new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"),
                column: "Time",
                value: new DateTime(2023, 10, 6, 13, 5, 6, 81, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[] { new Guid("f53c694b-050c-42a3-8b18-7d389ed240ae"), "Good morning friens", new DateTime(2023, 10, 6, 13, 5, 6, 81, DateTimeKind.Local).AddTicks(8969), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("05a0088a-8f0e-4dc2-a0d9-4ba8abd6b281"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("43fe52bd-caf3-4662-8f93-67f1da3113b8"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("326f3e96-6d39-47e9-b80e-2e3eafdfd364"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("e3c296c9-8d3e-467f-be9e-93f6bd7829bb") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ba02c76-2044-42d2-88e6-615109dc5d7e"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(5641), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 7, 9, 5, 6, 79, DateTimeKind.Local).AddTicks(5642), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("d00c531f-5958-4e78-a088-8db0557ae230"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(5651), false, false, null, " Software Enginer", new DateTime(2023, 10, 7, 19, 5, 6, 79, DateTimeKind.Local).AddTicks(5652), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

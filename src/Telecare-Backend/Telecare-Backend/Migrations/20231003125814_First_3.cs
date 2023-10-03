using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class First_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("61dd0e1b-a8c1-4adc-8ffe-23eb9b795b73"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4c843adc-4c33-4987-be69-1e0f41537f3b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("090cc4d4-a604-4f8f-98bd-5f60d5306a70"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("925df8f2-5863-434d-88cb-9f97aea02deb"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("b12c6ee8-766a-4246-9983-b7c1e06d2e3e"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("0b96a83d-454c-4a5d-a939-ce569f54ed56"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9f8cdcbd-4244-40e9-8303-e8c2b4feb0ea"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("61e904cc-691f-4e16-8019-4cafacf6d648"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("17e5f501-468d-4c94-994e-cce9bff703fc"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4165d980-446e-4315-ae7e-1a7862436a05"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("64f87be0-0f96-4519-afff-18db9a0d3248"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("591c3c89-2a05-4514-bc29-bcb191693875"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("8b4c5ef3-6820-4b88-92f1-73d8c9b5f036"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3edb54ab-9f19-45f6-a3ac-ec844a40c5a2"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("e54190cd-ae5f-4085-a877-a50397238c64"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("fb561be0-5a45-46c1-bbb2-c1a8c14d46a6"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5e757059-3a39-43e5-8ced-33ddb151d7e7"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fdf9ba3e-6542-4315-9252-b7c4ede8f8b6"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DoctorPatients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("a6b50b5c-3443-4800-bed3-3e338f9b0f46"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("913a77d4-e903-437a-a00f-a78cee2edace"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "9fcb7488-2a4d-493b-952b-e8bd52d3e5f7");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("146cf6f2-ec91-40c0-9f17-1d224ae4a00f"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("edd4e01f-a991-40ff-a523-ff0ba605225a"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("7ac677c5-a8c3-48a8-af72-ae0928a1eca5"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 12, 58, 14, 121, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("0f9a2718-8c12-4e94-afed-a6dc64044048"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("7aa2914f-b6c7-4ad9-afdf-7b1acadc1eb3"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("97d05fed-f7e1-44d6-a2bb-79647ab22085"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("8402d0cd-b8a4-4ad7-ad51-ef6dc8fa7fa5"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("202b1097-9cb9-42a8-a1e7-ed1101d962fe"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 12, 58, 14, 119, DateTimeKind.Utc).AddTicks(387), null, "Islamic University", new DateTime(2028, 10, 3, 18, 58, 14, 119, DateTimeKind.Local).AddTicks(393), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("6c9ba88a-156a-48c7-af3d-c12cae614bba"), false, "BA", null, null, new DateTime(2023, 10, 3, 12, 58, 14, 119, DateTimeKind.Utc).AddTicks(416), null, "Rajshahi University", new DateTime(2028, 10, 3, 18, 58, 14, 119, DateTimeKind.Local).AddTicks(417), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("730e2b9f-fcec-46d3-8dc2-8859f9142e4f"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("02574734-437f-496a-9756-1623bf0da18a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("72da4bff-1e7a-4afb-ae5a-86f33db8c88d"), false, false, false, new Guid("df3e8c77-5dec-4681-be45-008e2f6b646c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("8cb2b77a-4293-40e1-ba84-481a4f8acd18"), false, false, false, new Guid("e41c3a0a-f0ea-4b26-9c4e-d1120bd7719b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("10513ce1-7cc4-4958-b15d-87b037f15bda"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("eaf5ac49-7944-4eb3-a9e2-c685aa27c7e5"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("ae03376d-935a-4001-86d3-64d6bc3ae857"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("62b2677e-1ffb-4444-818b-4942281fc12d") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("8ebf13b3-64d6-40bd-8e90-fcc87a9bf121"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 18, 58, 14, 119, DateTimeKind.Local).AddTicks(2276), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 0, 58, 14, 119, DateTimeKind.Local).AddTicks(2277), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ffa793b5-1f2a-4aac-b581-38c3bb35d1c3"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 18, 58, 14, 119, DateTimeKind.Local).AddTicks(2264), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 14, 58, 14, 119, DateTimeKind.Local).AddTicks(2268), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients");

            migrationBuilder.DropIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a6b50b5c-3443-4800-bed3-3e338f9b0f46"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("913a77d4-e903-437a-a00f-a78cee2edace"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("146cf6f2-ec91-40c0-9f17-1d224ae4a00f"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("edd4e01f-a991-40ff-a523-ff0ba605225a"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("7ac677c5-a8c3-48a8-af72-ae0928a1eca5"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("0f9a2718-8c12-4e94-afed-a6dc64044048"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("7aa2914f-b6c7-4ad9-afdf-7b1acadc1eb3"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("97d05fed-f7e1-44d6-a2bb-79647ab22085"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("8402d0cd-b8a4-4ad7-ad51-ef6dc8fa7fa5"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("202b1097-9cb9-42a8-a1e7-ed1101d962fe"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6c9ba88a-156a-48c7-af3d-c12cae614bba"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("730e2b9f-fcec-46d3-8dc2-8859f9142e4f"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("72da4bff-1e7a-4afb-ae5a-86f33db8c88d"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("8cb2b77a-4293-40e1-ba84-481a4f8acd18"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("10513ce1-7cc4-4958-b15d-87b037f15bda"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("eaf5ac49-7944-4eb3-a9e2-c685aa27c7e5"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("ae03376d-935a-4001-86d3-64d6bc3ae857"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("8ebf13b3-64d6-40bd-8e90-fcc87a9bf121"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ffa793b5-1f2a-4aac-b581-38c3bb35d1c3"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DoctorPatients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients",
                columns: new[] { "PatientId", "DoctorId" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("61dd0e1b-a8c1-4adc-8ffe-23eb9b795b73"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("4c843adc-4c33-4987-be69-1e0f41537f3b"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "5d9b3dec-6bb9-4775-a4d3-9e1d689d65b1");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("090cc4d4-a604-4f8f-98bd-5f60d5306a70"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("925df8f2-5863-434d-88cb-9f97aea02deb"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("b12c6ee8-766a-4246-9983-b7c1e06d2e3e"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 12, 54, 25, 729, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("0b96a83d-454c-4a5d-a939-ce569f54ed56"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "DoctorId", "PatientId" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("9f8cdcbd-4244-40e9-8303-e8c2b4feb0ea"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("61e904cc-691f-4e16-8019-4cafacf6d648"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("17e5f501-468d-4c94-994e-cce9bff703fc"), false, "BA", null, null, new DateTime(2023, 10, 3, 12, 54, 25, 727, DateTimeKind.Utc).AddTicks(3230), null, "Rajshahi University", new DateTime(2028, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(3231), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("4165d980-446e-4315-ae7e-1a7862436a05"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 12, 54, 25, 727, DateTimeKind.Utc).AddTicks(3167), null, "Islamic University", new DateTime(2028, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(3200), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("64f87be0-0f96-4519-afff-18db9a0d3248"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("c8ac8698-7fa0-4424-b493-1748035dda70") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("591c3c89-2a05-4514-bc29-bcb191693875"), false, false, false, new Guid("40676daf-cc0b-4219-82dc-ae42457863bc"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("8b4c5ef3-6820-4b88-92f1-73d8c9b5f036"), false, false, false, new Guid("8c415d2e-7064-4792-8a5f-69fa5c7e66fe"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3edb54ab-9f19-45f6-a3ac-ec844a40c5a2"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("e54190cd-ae5f-4085-a877-a50397238c64"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("fb561be0-5a45-46c1-bbb2-c1a8c14d46a6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("03b9472b-f93a-4fa2-98ca-332f1cec8262") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5e757059-3a39-43e5-8ced-33ddb151d7e7"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(4231), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 0, 54, 25, 727, DateTimeKind.Local).AddTicks(4232), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fdf9ba3e-6542-4315-9252-b7c4ede8f8b6"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(4219), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 14, 54, 25, 727, DateTimeKind.Local).AddTicks(4221), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class First_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorProfiles",
                table: "DoctorProfiles");

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
                keyValue: new Guid("7aa2914f-b6c7-4ad9-afdf-7b1acadc1eb3"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
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
                table: "DoctorProfiles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorProfiles",
                table: "DoctorProfiles",
                columns: new[] { "MemberId", "DoctorID" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("288bb4bb-649b-4e9f-a8e2-faafe1bd5450"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("a4e51068-4262-496e-a4e7-1d5781c3951e"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "7f8e7f11-7945-433c-b007-ac3bbd3b7003");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("03f0001b-5c99-470c-a1b4-75a9169567f9"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("a4317d58-e2c9-4d5e-9943-c9809dd6b9a5"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("c873e746-a5eb-466a-8dba-ca50566326d7"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 13, 1, 17, 755, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("bb6c6391-a27f-4eb5-8edc-0e44670eff9f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("1acfab95-d5a3-4c89-ac57-bb14f7ffdb18"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "DoctorID", "MemberId" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("0173c728-5716-4355-84b8-5b75e50f7f22"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("e0d36021-840f-436a-ac44-7f1f296af5f8"), false, "BA", null, null, new DateTime(2023, 10, 3, 13, 1, 17, 753, DateTimeKind.Utc).AddTicks(9982), null, "Rajshahi University", new DateTime(2028, 10, 3, 19, 1, 17, 753, DateTimeKind.Local).AddTicks(9982), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("e5a4dd0b-e784-4eb2-ad12-22f83595586f"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 13, 1, 17, 753, DateTimeKind.Utc).AddTicks(9949), null, "Islamic University", new DateTime(2028, 10, 3, 19, 1, 17, 753, DateTimeKind.Local).AddTicks(9957), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("e892b2c1-3a6c-4e9e-9338-1450c117709d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("4656cf23-8b65-4d77-aa42-818b2397accd") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("11ca36c8-f503-4a2e-85cc-5b60a4ec2f0c"), false, false, false, new Guid("7fb57deb-7a2f-4819-944e-64e72b166bd8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("342e34b8-1996-416c-b775-5ac453627a0f"), false, false, false, new Guid("d5acbd09-a5ba-4713-9fcd-7a671bab8d53"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3a344aa5-42d0-4117-9d0e-b36440227472"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("e46f1dca-d3ba-494a-a01d-2134c4c8bb57"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("2eb72812-a037-4aa8-bbe2-7b184da5c7aa"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("e813ddfc-7f49-4d53-b545-264e5c258ba3") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("b618ef99-d196-48f7-9e9c-269f2acd4372"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 19, 1, 17, 754, DateTimeKind.Local).AddTicks(948), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 1, 1, 17, 754, DateTimeKind.Local).AddTicks(949), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ec321e4f-9745-4cf2-8e7a-d8ce6a55fdcb"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 19, 1, 17, 754, DateTimeKind.Local).AddTicks(935), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 15, 1, 17, 754, DateTimeKind.Local).AddTicks(938), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorProfiles",
                table: "DoctorProfiles");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("288bb4bb-649b-4e9f-a8e2-faafe1bd5450"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("a4e51068-4262-496e-a4e7-1d5781c3951e"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("03f0001b-5c99-470c-a1b4-75a9169567f9"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a4317d58-e2c9-4d5e-9943-c9809dd6b9a5"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("c873e746-a5eb-466a-8dba-ca50566326d7"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("bb6c6391-a27f-4eb5-8edc-0e44670eff9f"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("1acfab95-d5a3-4c89-ac57-bb14f7ffdb18"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumns: new[] { "DoctorID", "MemberId" },
                keyValues: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("0173c728-5716-4355-84b8-5b75e50f7f22"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e0d36021-840f-436a-ac44-7f1f296af5f8"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e5a4dd0b-e784-4eb2-ad12-22f83595586f"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("e892b2c1-3a6c-4e9e-9338-1450c117709d"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("11ca36c8-f503-4a2e-85cc-5b60a4ec2f0c"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("342e34b8-1996-416c-b775-5ac453627a0f"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3a344aa5-42d0-4117-9d0e-b36440227472"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("e46f1dca-d3ba-494a-a01d-2134c4c8bb57"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("2eb72812-a037-4aa8-bbe2-7b184da5c7aa"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("b618ef99-d196-48f7-9e9c-269f2acd4372"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ec321e4f-9745-4cf2-8e7a-d8ce6a55fdcb"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DoctorProfiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorProfiles",
                table: "DoctorProfiles",
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
        }
    }
}

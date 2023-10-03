using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Doctor_Complain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorComments_AspNetUsers_MemberId",
                table: "DoctorComments");

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

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "DoctorComments",
                newName: "PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorComments_MemberId",
                table: "DoctorComments",
                newName: "IX_DoctorComments_PatientId");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("41e1bfbd-33dd-4ba3-9585-8d0dcd4223fb"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("b2c25ede-939e-4d6a-8e77-06a898f94ece"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "870ec3c7-777b-45db-bd7e-3293c774a1d9");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("39549ee2-dc55-4e83-9696-80f5cc6fc13e"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("86032082-da29-49a4-8276-c5e00129dfa4"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("d37009ca-abb7-43fa-b884-44304359ff23"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 13, 25, 31, 62, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("5ab44ca3-f37a-4857-a251-acd47c4e0f74"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("527301fd-e8c4-4265-a14d-c023270de7ba"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("020edc43-5fc2-418d-85bb-9390e2968c91"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("88b9bf5d-fca5-40dd-b4d9-4a94051893a3"), false, "BA", null, null, new DateTime(2023, 10, 3, 13, 25, 31, 60, DateTimeKind.Utc).AddTicks(2027), null, "Rajshahi University", new DateTime(2028, 10, 3, 19, 25, 31, 60, DateTimeKind.Local).AddTicks(2028), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("ebc53828-e113-4803-a690-5de4edeae423"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 13, 25, 31, 60, DateTimeKind.Utc).AddTicks(2001), null, "Islamic University", new DateTime(2028, 10, 3, 19, 25, 31, 60, DateTimeKind.Local).AddTicks(2007), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("77fece22-51bf-4837-a906-febc7f0e9596"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("dd982eb7-f054-46e1-a9e5-d4b184058040") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("a35b97e1-8ad6-4fbf-b171-129dafc42c47"), false, false, false, new Guid("df66f36c-9642-4ee8-bed4-86dfffe79ae1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("b8cb3474-0a83-44c2-ba6e-2a4284c72ee9"), false, false, false, new Guid("edb77332-3f95-4d3e-84ab-e3f546f52a2b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("40f0ee29-7e8f-4344-8906-34ab184affd8"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("97ad48c9-5ce8-44c8-b17a-6af615acb518"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("f6a3c90a-db07-4202-89a8-a526442e4657"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("f09866d6-72de-4e5b-b34f-7949192a5fc4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("b4843e04-675a-4cf1-8691-8e6af525388c") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("047c4595-020f-4077-ae13-6a9275769326"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 19, 25, 31, 60, DateTimeKind.Local).AddTicks(3028), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 1, 25, 31, 60, DateTimeKind.Local).AddTicks(3029), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("b8ef4004-d715-4644-9519-25d6076a9c90"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 19, 25, 31, 60, DateTimeKind.Local).AddTicks(3015), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 15, 25, 31, 60, DateTimeKind.Local).AddTicks(3018), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientComplains_PatientId",
                table: "PatientComplains",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorComments_AspNetUsers_PatientId",
                table: "DoctorComments",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientComplains_AspNetUsers_PatientId",
                table: "PatientComplains",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorComments_AspNetUsers_PatientId",
                table: "DoctorComments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientComplains_AspNetUsers_PatientId",
                table: "PatientComplains");

            migrationBuilder.DropIndex(
                name: "IX_PatientComplains_PatientId",
                table: "PatientComplains");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("41e1bfbd-33dd-4ba3-9585-8d0dcd4223fb"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b2c25ede-939e-4d6a-8e77-06a898f94ece"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("39549ee2-dc55-4e83-9696-80f5cc6fc13e"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("86032082-da29-49a4-8276-c5e00129dfa4"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("d37009ca-abb7-43fa-b884-44304359ff23"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("5ab44ca3-f37a-4857-a251-acd47c4e0f74"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("527301fd-e8c4-4265-a14d-c023270de7ba"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("020edc43-5fc2-418d-85bb-9390e2968c91"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("88b9bf5d-fca5-40dd-b4d9-4a94051893a3"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ebc53828-e113-4803-a690-5de4edeae423"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("77fece22-51bf-4837-a906-febc7f0e9596"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("a35b97e1-8ad6-4fbf-b171-129dafc42c47"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("b8cb3474-0a83-44c2-ba6e-2a4284c72ee9"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("40f0ee29-7e8f-4344-8906-34ab184affd8"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("97ad48c9-5ce8-44c8-b17a-6af615acb518"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f6a3c90a-db07-4202-89a8-a526442e4657"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("f09866d6-72de-4e5b-b34f-7949192a5fc4"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("047c4595-020f-4077-ae13-6a9275769326"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("b8ef4004-d715-4644-9519-25d6076a9c90"));

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "DoctorComments",
                newName: "MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorComments_PatientId",
                table: "DoctorComments",
                newName: "IX_DoctorComments_MemberId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorComments_AspNetUsers_MemberId",
                table: "DoctorComments",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Doctor_Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("098b060f-2c23-45f0-aa89-9bb77c39682a"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("c612ea9e-f717-47b1-9525-1449ae134777"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("2b3bbd33-80af-47cd-86fe-fd82f0c02d3b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("81b5bb68-bf0a-4d48-8625-d1736886870f"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("4fc5bf06-fe0e-477c-91d7-28f607c8ad98"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("e7becdcd-0866-42ba-9a8d-b2864bd6d6ce"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2bf0b318-c1a8-4928-96d8-61c59dd9d2b6"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("978de6fc-0e7c-41b6-a4e7-62acd81c1399"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4a4313aa-498a-411d-85f6-580a18af7030"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6723a0e3-ad20-400b-8664-524c677bec95"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("433c1e1a-b4f5-4036-9764-5296fbe05651"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("c32fbfc4-3b13-4d8a-8e28-19a22b38435e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("eb0c6538-a507-4823-b177-e95e1eb55f10"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("8e6ff1c1-a1a9-43e6-ab1a-01d1b7206d01"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("032cd540-7f95-4b5e-97a6-e8f67d86cd11"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("4b0f175f-85f4-4674-8f84-d9cb557fe3f5"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("21369d78-509c-47ba-9dfb-abd217ccd4dd"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7b8d188a-df28-46c0-8bb3-2a1e17bb4d1c"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("dee4023e-0bd3-46a2-a8e4-597e04a5dba0"));

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "DoctorComments",
                newName: "MemberId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "DoctorComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("46f980d5-211a-436e-8085-a26fc8ffc652"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("cfeebdb7-7e5d-4117-bc2f-c7a48e387f25"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "0f076ac4-c726-401b-b14c-7af7730976d9");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("3b36ea28-41db-4fb5-b5d8-19750399bffd"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("3e7803ca-f22c-4eef-9505-a88335ba085e"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("92c68f26-4840-447a-b192-3e9a5e69ccf7"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 12, 2, 14, 313, DateTimeKind.Utc).AddTicks(1797) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("1a32224e-96cb-45d0-9901-cce9b675da34"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("67d9f9ca-1bf4-4249-98f1-e05f9b8199f8") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("d3301757-f69f-49b0-a7a0-c71c59dee6d3"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("0d338d5a-ef28-4c83-a47d-6d9fd9620087"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("2ed003a4-3bf4-4aca-949a-3922327ecd0f"), false, "BA", null, null, new DateTime(2023, 10, 3, 12, 2, 14, 312, DateTimeKind.Utc).AddTicks(1410), null, "Rajshahi University", new DateTime(2028, 10, 3, 18, 2, 14, 312, DateTimeKind.Local).AddTicks(1411), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("7bf44dbd-8053-4d94-826a-d3ceea7275ab"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 12, 2, 14, 312, DateTimeKind.Utc).AddTicks(1382), null, "Islamic University", new DateTime(2028, 10, 3, 18, 2, 14, 312, DateTimeKind.Local).AddTicks(1387), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("2409e659-fccc-4baf-bd37-d7c7cfe93483"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("32274205-53a4-4ff4-a12b-dff3a9c01697") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("7dd24b8c-b7e5-4c4b-9398-b4435beb84bd"), false, false, false, new Guid("99b0d6b2-11df-4272-9449-e4fd1da38edc"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("87ac1dfe-2b72-4663-a904-4555b9ca7a36"), false, false, false, new Guid("d223077a-15fa-476b-9537-dcabfee4a0c3"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("0b47c16f-f106-49a1-ac4e-11329e27368b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("b5070f11-1ced-4afc-8bc2-c70d30451720"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("a839ac9e-5597-462f-8d14-73d8de37f6f1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("e3ec0e7c-4c9c-4ef0-83b0-32590683fe2f") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("7e08cee3-44fe-4f9a-837a-7667a43f9ff1"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 18, 2, 14, 312, DateTimeKind.Local).AddTicks(2354), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 14, 2, 14, 312, DateTimeKind.Local).AddTicks(2357), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("eb200b1f-4239-4359-a063-820c70b641af"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 18, 2, 14, 312, DateTimeKind.Local).AddTicks(2368), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 0, 2, 14, 312, DateTimeKind.Local).AddTicks(2368), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorComments_MemberId",
                table: "DoctorComments",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorComments_AspNetUsers_MemberId",
                table: "DoctorComments",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorComments_AspNetUsers_MemberId",
                table: "DoctorComments");

            migrationBuilder.DropIndex(
                name: "IX_DoctorComments_MemberId",
                table: "DoctorComments");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("46f980d5-211a-436e-8085-a26fc8ffc652"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("cfeebdb7-7e5d-4117-bc2f-c7a48e387f25"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3b36ea28-41db-4fb5-b5d8-19750399bffd"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3e7803ca-f22c-4eef-9505-a88335ba085e"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("92c68f26-4840-447a-b192-3e9a5e69ccf7"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("1a32224e-96cb-45d0-9901-cce9b675da34"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d3301757-f69f-49b0-a7a0-c71c59dee6d3"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("0d338d5a-ef28-4c83-a47d-6d9fd9620087"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("2ed003a4-3bf4-4aca-949a-3922327ecd0f"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("7bf44dbd-8053-4d94-826a-d3ceea7275ab"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("2409e659-fccc-4baf-bd37-d7c7cfe93483"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("7dd24b8c-b7e5-4c4b-9398-b4435beb84bd"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("87ac1dfe-2b72-4663-a904-4555b9ca7a36"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("0b47c16f-f106-49a1-ac4e-11329e27368b"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("b5070f11-1ced-4afc-8bc2-c70d30451720"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("a839ac9e-5597-462f-8d14-73d8de37f6f1"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7e08cee3-44fe-4f9a-837a-7667a43f9ff1"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("eb200b1f-4239-4359-a063-820c70b641af"));

            migrationBuilder.DropColumn(
                name: "Time",
                table: "DoctorComments");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "DoctorComments",
                newName: "PatientId");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("098b060f-2c23-45f0-aa89-9bb77c39682a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("c612ea9e-f717-47b1-9525-1449ae134777"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "840c5e4b-3b5d-4c07-89f7-780aa7273477");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("2b3bbd33-80af-47cd-86fe-fd82f0c02d3b"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("81b5bb68-bf0a-4d48-8625-d1736886870f"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("4fc5bf06-fe0e-477c-91d7-28f607c8ad98"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("e7becdcd-0866-42ba-9a8d-b2864bd6d6ce"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("c690aebb-5e5d-432e-bcfe-adae1e3bed2a") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("2bf0b318-c1a8-4928-96d8-61c59dd9d2b6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("978de6fc-0e7c-41b6-a4e7-62acd81c1399"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("4a4313aa-498a-411d-85f6-580a18af7030"), false, "BA", null, null, new DateTime(2023, 10, 3, 11, 24, 13, 958, DateTimeKind.Utc).AddTicks(7484), null, "Rajshahi University", new DateTime(2028, 10, 3, 17, 24, 13, 958, DateTimeKind.Local).AddTicks(7484), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("6723a0e3-ad20-400b-8664-524c677bec95"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 11, 24, 13, 958, DateTimeKind.Utc).AddTicks(7350), null, "Islamic University", new DateTime(2028, 10, 3, 17, 24, 13, 958, DateTimeKind.Local).AddTicks(7393), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("433c1e1a-b4f5-4036-9764-5296fbe05651"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("3e55beb1-4083-4529-bb42-4dd9cf06d8e2") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("c32fbfc4-3b13-4d8a-8e28-19a22b38435e"), false, false, false, new Guid("6568b627-0ae6-4dfe-8710-8dfda84c447f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("eb0c6538-a507-4823-b177-e95e1eb55f10"), false, false, false, new Guid("a39260d9-7bba-469b-8ec5-6903870be4ff"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("8e6ff1c1-a1a9-43e6-ab1a-01d1b7206d01"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("032cd540-7f95-4b5e-97a6-e8f67d86cd11"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("4b0f175f-85f4-4674-8f84-d9cb557fe3f5"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("21369d78-509c-47ba-9dfb-abd217ccd4dd"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("bf3697c5-05ca-4363-84c1-e3c38a9193e8") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("7b8d188a-df28-46c0-8bb3-2a1e17bb4d1c"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 17, 24, 13, 958, DateTimeKind.Local).AddTicks(8605), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 13, 24, 13, 958, DateTimeKind.Local).AddTicks(8607), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("dee4023e-0bd3-46a2-a8e4-597e04a5dba0"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 17, 24, 13, 958, DateTimeKind.Local).AddTicks(8617), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 23, 24, 13, 958, DateTimeKind.Local).AddTicks(8617), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

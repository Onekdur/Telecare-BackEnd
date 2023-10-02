using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Patient_Modification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DoctorPatients_PatientId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PatientId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b71c3878-9819-4ab4-af9e-b62e2cb7fb51"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e69fe960-0cf8-4b22-a636-ee452ee1ec10"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("26db191f-91bc-4d5b-b3d4-fa0e5e10b70c"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("2bbb801c-eb66-44d9-88f6-85c298d55a01"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("e724933b-d8f2-4d0f-9e6d-03f8e4fd2915"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("7d2fcbfc-c440-4950-b4c0-92d3632fdd14"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("39ab72a0-15d7-4812-b47d-59564a6c4488"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("09086794-6de5-4dc4-b93d-88862852b073"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("1cbe3604-1276-4af0-900a-eee262bbf572"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("c3cd9dac-9f9c-4350-a330-3708b786ae59"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("154223c0-547b-438d-9f25-b842cbf8c57d"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("7ab205b4-f145-4c85-a5db-2f7a414b4e22"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("bc047b6a-dc9d-4633-8730-d1e3e1db10e6"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("00517970-ed9f-48e0-a1db-13fb825e5f51"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("b5b3798a-2214-4443-b500-2da98f3aeceb"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f4f665cd-07c0-45ec-808b-69184aa98910"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("3e8afb02-8d91-42cb-9877-31bf38c01fae"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("8709fd6b-25f1-4601-bfc1-b182ac242d07"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d23ac85e-c5cc-4eac-89c4-adc684fba93b"));

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("94321ddb-da34-4261-8ad7-a3cc1bef48ef"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("bd76928a-164c-42a2-9b49-8cb3826da3aa"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "7f37c04d-ffbc-4db6-a3f2-9f02b240079e");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("88f8ea51-9e1e-4e0d-b653-44b766e471cc"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("95904e3d-6c41-4b70-a26c-e837de5db53a"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("11c38246-cf35-481b-b99f-2ba31eae0d9f"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("c6b5f871-fed5-4f99-b3a1-61531b666282"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("bad7671e-ac9b-4cbe-9384-b911091876a7") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("ff1a7999-0419-4f1f-ac50-dafd2bb51d7b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("76a43d52-80db-45bb-a86d-7e9f107e61e8"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("467ac3c5-d71d-434b-8019-ba8acecbbbf1"), false, "BA", null, null, new DateTime(2023, 10, 2, 13, 29, 53, 830, DateTimeKind.Utc).AddTicks(5610), null, "Rajshahi University", new DateTime(2028, 10, 2, 19, 29, 53, 830, DateTimeKind.Local).AddTicks(5611), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("e52ece94-6560-4742-83be-649a3f000144"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 13, 29, 53, 830, DateTimeKind.Utc).AddTicks(5582), null, "Islamic University", new DateTime(2028, 10, 2, 19, 29, 53, 830, DateTimeKind.Local).AddTicks(5586), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("aba5bad6-a4e1-4e8e-b1b8-cfaa480fff89"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("e48c6241-3d79-4a9a-a510-38c7f67baa62") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("3df9eadd-9651-45f7-9c09-b759c105185a"), false, false, false, new Guid("71f084ec-05f5-4c93-980f-72784794816a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("a01c3b66-80f9-4259-805a-be4857151b55"), false, false, false, new Guid("139ad32a-6c7b-430b-a1cd-13c3afdcd6b4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("fd36e66b-f970-44a9-ad86-896cb483180c"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3fae886b-c838-41b9-88a5-02291ca2693b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("8616896a-4f5a-4aca-9eda-d5c00d9a2c55"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("908d1da1-4dc0-4110-9f98-609fb02d0ebb"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("39dd4ea1-8c93-46d2-99eb-ca07079a0b1f") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("40348f40-412d-45e2-8a90-a36ee5c69962"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 19, 29, 53, 830, DateTimeKind.Local).AddTicks(6534), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 15, 29, 53, 830, DateTimeKind.Local).AddTicks(6536), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("b8fcf171-d9ef-44d2-b376-b9ec5728f5fd"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 19, 29, 53, 830, DateTimeKind.Local).AddTicks(6550), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 1, 29, 53, 830, DateTimeKind.Local).AddTicks(6551), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatients_AspNetUsers_PatientId",
                table: "DoctorPatients",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatients_AspNetUsers_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DropIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("94321ddb-da34-4261-8ad7-a3cc1bef48ef"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("bd76928a-164c-42a2-9b49-8cb3826da3aa"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("88f8ea51-9e1e-4e0d-b653-44b766e471cc"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("95904e3d-6c41-4b70-a26c-e837de5db53a"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("11c38246-cf35-481b-b99f-2ba31eae0d9f"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("c6b5f871-fed5-4f99-b3a1-61531b666282"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("ff1a7999-0419-4f1f-ac50-dafd2bb51d7b"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("76a43d52-80db-45bb-a86d-7e9f107e61e8"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("467ac3c5-d71d-434b-8019-ba8acecbbbf1"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e52ece94-6560-4742-83be-649a3f000144"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("aba5bad6-a4e1-4e8e-b1b8-cfaa480fff89"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("3df9eadd-9651-45f7-9c09-b759c105185a"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("a01c3b66-80f9-4259-805a-be4857151b55"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("fd36e66b-f970-44a9-ad86-896cb483180c"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3fae886b-c838-41b9-88a5-02291ca2693b"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("8616896a-4f5a-4aca-9eda-d5c00d9a2c55"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("908d1da1-4dc0-4110-9f98-609fb02d0ebb"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("40348f40-412d-45e2-8a90-a36ee5c69962"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("b8fcf171-d9ef-44d2-b376-b9ec5728f5fd"));

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("b71c3878-9819-4ab4-af9e-b62e2cb7fb51"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("e69fe960-0cf8-4b22-a636-ee452ee1ec10"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                columns: new[] { "ConcurrencyStamp", "PatientId" },
                values: new object[] { "efc67281-7aed-49dd-901e-7c38045f36b3", null });

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("26db191f-91bc-4d5b-b3d4-fa0e5e10b70c"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("2bbb801c-eb66-44d9-88f6-85c298d55a01"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("e724933b-d8f2-4d0f-9e6d-03f8e4fd2915"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("7d2fcbfc-c440-4950-b4c0-92d3632fdd14"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("f2993ab2-0d74-4171-a341-82ae0f8a34c2") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("39ab72a0-15d7-4812-b47d-59564a6c4488"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("09086794-6de5-4dc4-b93d-88862852b073"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("1cbe3604-1276-4af0-900a-eee262bbf572"), false, "BA", null, null, new DateTime(2023, 10, 2, 13, 27, 13, 62, DateTimeKind.Utc).AddTicks(1728), null, "Rajshahi University", new DateTime(2028, 10, 2, 19, 27, 13, 62, DateTimeKind.Local).AddTicks(1729), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("c3cd9dac-9f9c-4350-a330-3708b786ae59"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 13, 27, 13, 62, DateTimeKind.Utc).AddTicks(1699), null, "Islamic University", new DateTime(2028, 10, 2, 19, 27, 13, 62, DateTimeKind.Local).AddTicks(1705), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("154223c0-547b-438d-9f25-b842cbf8c57d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("371ff839-b9b6-484d-bcea-67d2282d090c") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("7ab205b4-f145-4c85-a5db-2f7a414b4e22"), false, false, false, new Guid("17cbc3d0-bf4d-489c-9e77-a39350f12edb"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("bc047b6a-dc9d-4633-8730-d1e3e1db10e6"), false, false, false, new Guid("692f9136-59a8-4b31-bc38-6350fde5b5ac"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("00517970-ed9f-48e0-a1db-13fb825e5f51"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("b5b3798a-2214-4443-b500-2da98f3aeceb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("f4f665cd-07c0-45ec-808b-69184aa98910"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("3e8afb02-8d91-42cb-9877-31bf38c01fae"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("14e16e46-8b7e-4014-a05d-f9111ae6c9dd") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("8709fd6b-25f1-4601-bfc1-b182ac242d07"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 19, 27, 13, 62, DateTimeKind.Local).AddTicks(2665), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 1, 27, 13, 62, DateTimeKind.Local).AddTicks(2665), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("d23ac85e-c5cc-4eac-89c4-adc684fba93b"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 19, 27, 13, 62, DateTimeKind.Local).AddTicks(2652), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 15, 27, 13, 62, DateTimeKind.Local).AddTicks(2655), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PatientId",
                table: "AspNetUsers",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DoctorPatients_PatientId",
                table: "AspNetUsers",
                column: "PatientId",
                principalTable: "DoctorPatients",
                principalColumn: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("49ec84e9-8519-42f2-85bd-ba16557e01ab"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("3ef6b1c2-724b-4404-b703-169946e125e2"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("124433a0-3f85-4f14-90d4-62c7792429a4"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ae1b7bcf-ffb4-4b04-a0ba-874b3dcdb938"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("f0dfe859-c8ff-406e-ba54-2b72b0734b0d"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("3b4d58e9-e1e3-4819-bdfd-7da7d86dde9f"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("9748a9b2-1766-4b87-8306-86ac4b5bdd89"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("d4be3e81-fdf8-4c84-a51c-e8e4d2791848"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("0dcbc5de-f8f2-4468-8a0c-cf9456839a87"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ba8dcaf9-6bc0-47c3-9bfc-926810d453f4"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("1435f0f9-1447-44be-85b8-f8d6a0db8bb1"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("16bc35e3-90f3-41cf-9b69-efca279f271e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("bee05847-8504-42c2-b565-7b55bb019ecb"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("4ad1fe5c-5280-461d-b36b-8895e1898dd8"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("38c6888d-1ef7-459a-8c6c-d85452136ea6"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("cb1110ab-cf6b-4d01-8a8d-6952047dd678"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("6c75c774-afca-4081-89d3-db16af47dc6c"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("d85314ec-6e74-4ff7-9767-440cd58c0b2e"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ec7ca561-14e0-4af8-9b8d-17bfd13d7d4e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("49ec84e9-8519-42f2-85bd-ba16557e01ab"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("3ef6b1c2-724b-4404-b703-169946e125e2"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "d0702549-c9c5-403c-a6a5-a8001015aacd");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("124433a0-3f85-4f14-90d4-62c7792429a4"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ae1b7bcf-ffb4-4b04-a0ba-874b3dcdb938"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("f0dfe859-c8ff-406e-ba54-2b72b0734b0d"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("3b4d58e9-e1e3-4819-bdfd-7da7d86dde9f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("a5925346-db4f-4d67-b81d-3286cb928e77") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("9748a9b2-1766-4b87-8306-86ac4b5bdd89"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("d4be3e81-fdf8-4c84-a51c-e8e4d2791848"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("0dcbc5de-f8f2-4468-8a0c-cf9456839a87"), false, "BA", null, null, new DateTime(2023, 10, 2, 10, 2, 41, 853, DateTimeKind.Utc).AddTicks(1300), null, "Rajshahi University", new DateTime(2028, 10, 2, 16, 2, 41, 853, DateTimeKind.Local).AddTicks(1300), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("ba8dcaf9-6bc0-47c3-9bfc-926810d453f4"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 10, 2, 41, 853, DateTimeKind.Utc).AddTicks(1266), null, "Islamic University", new DateTime(2028, 10, 2, 16, 2, 41, 853, DateTimeKind.Local).AddTicks(1272), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("1435f0f9-1447-44be-85b8-f8d6a0db8bb1"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("95f27cf6-068e-4c73-ace3-50cc86279365") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("16bc35e3-90f3-41cf-9b69-efca279f271e"), false, false, false, new Guid("dbd04f0a-f03f-4cb1-87c9-23c153928dc5"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("bee05847-8504-42c2-b565-7b55bb019ecb"), false, false, false, new Guid("c8f7abda-5b17-4278-8587-dbb0cacc863f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("4ad1fe5c-5280-461d-b36b-8895e1898dd8"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("38c6888d-1ef7-459a-8c6c-d85452136ea6"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("cb1110ab-cf6b-4d01-8a8d-6952047dd678"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("6c75c774-afca-4081-89d3-db16af47dc6c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("b6ced54f-5b8e-4688-8e71-ebe9507f97e8") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("d85314ec-6e74-4ff7-9767-440cd58c0b2e"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 16, 2, 41, 853, DateTimeKind.Local).AddTicks(2663), false, false, null, " Software Enginer", new DateTime(2023, 10, 3, 22, 2, 41, 853, DateTimeKind.Local).AddTicks(2664), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ec7ca561-14e0-4af8-9b8d-17bfd13d7d4e"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 16, 2, 41, 853, DateTimeKind.Local).AddTicks(2650), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 12, 2, 41, 853, DateTimeKind.Local).AddTicks(2652), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
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
    }
}

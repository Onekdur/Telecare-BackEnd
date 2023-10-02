using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Complain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ea588aba-def0-44f6-8def-9588be508ac2"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("16b509bf-0c76-4ec6-989d-f02bd327c289"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0a2cb079-ede8-40ee-9227-93d430eb117b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6b15414a-4d68-473b-939c-d03c70d10b26"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("0da8867d-134f-4adf-b40e-91ce0b7cebcd"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("e7a843b9-9597-4bd9-b531-bb322c633526"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("b9335790-b96a-4606-891e-3e879b064f82"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("cfd58afb-364d-4746-89a3-095a7486a75f"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("66a855e7-13cb-4bb9-a9e5-df4a43f1b557"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("9b0a0959-289f-4ce8-91c3-7e192f203a27"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("660e5039-53e8-4e27-92fd-5f480d15a4fb"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("3decf149-955f-42e7-ad9a-929255467f5e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("ece52685-2df4-4c7e-be9b-d2ceaea0469a"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("a1a379f0-e63f-4234-8f98-2717fcc92530"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("ef797492-647b-4adf-b5af-3f6badee3ff3"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0e565c84-945d-44f0-97f9-b0869f9b8146"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5970e7ff-3c5b-4c15-b1ff-177a163ccdf8"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ed06e92a-2b00-4d42-9009-e3cc9336d3b6"));

            migrationBuilder.CreateTable(
                name: "PatientComplains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientComplains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientComplains_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_PatientComplains_DoctorId",
                table: "PatientComplains",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientComplains");

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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("ea588aba-def0-44f6-8def-9588be508ac2"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("16b509bf-0c76-4ec6-989d-f02bd327c289"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "4c65bdff-071a-48f5-80a2-f4d9313c4080");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("0a2cb079-ede8-40ee-9227-93d430eb117b"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("6b15414a-4d68-473b-939c-d03c70d10b26"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("0da8867d-134f-4adf-b40e-91ce0b7cebcd"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("e7a843b9-9597-4bd9-b531-bb322c633526"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("5d0be66b-5217-44a9-8b95-d66b96d6042a") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("b9335790-b96a-4606-891e-3e879b064f82"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("cfd58afb-364d-4746-89a3-095a7486a75f"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("66a855e7-13cb-4bb9-a9e5-df4a43f1b557"), false, "BA", null, null, new DateTime(2023, 10, 2, 9, 54, 34, 219, DateTimeKind.Utc).AddTicks(9477), null, "Rajshahi University", new DateTime(2028, 10, 2, 15, 54, 34, 219, DateTimeKind.Local).AddTicks(9477), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("9b0a0959-289f-4ce8-91c3-7e192f203a27"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 9, 54, 34, 219, DateTimeKind.Utc).AddTicks(9446), null, "Islamic University", new DateTime(2028, 10, 2, 15, 54, 34, 219, DateTimeKind.Local).AddTicks(9449), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("660e5039-53e8-4e27-92fd-5f480d15a4fb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("554cf895-b285-4e52-8441-d09a7d80c409") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("3decf149-955f-42e7-ad9a-929255467f5e"), false, false, false, new Guid("a75503a3-2c03-447d-bea9-c497471b8e45"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("ece52685-2df4-4c7e-be9b-d2ceaea0469a"), false, false, false, new Guid("c831d710-8081-414e-9ae2-6ebd33c9f4b8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("a1a379f0-e63f-4234-8f98-2717fcc92530"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("ef797492-647b-4adf-b5af-3f6badee3ff3"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("0e565c84-945d-44f0-97f9-b0869f9b8146"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("56dc479f-edda-478b-bafc-ecd0757026b7") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5970e7ff-3c5b-4c15-b1ff-177a163ccdf8"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 15, 54, 34, 220, DateTimeKind.Local).AddTicks(348), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 11, 54, 34, 220, DateTimeKind.Local).AddTicks(350), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ed06e92a-2b00-4d42-9009-e3cc9336d3b6"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 15, 54, 34, 220, DateTimeKind.Local).AddTicks(363), false, false, null, " Software Enginer", new DateTime(2023, 10, 3, 21, 54, 34, 220, DateTimeKind.Local).AddTicks(364), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

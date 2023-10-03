using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Doctor_Profile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("74f6c753-8e44-4e4e-89e6-f60eac62760f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("715018cd-13d4-4b55-9df3-4d816307a1af"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("67cd293f-a5ca-40c9-81c4-82328aadac25"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b339b7f4-0c36-4509-8abc-2bc7b5d18b13"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("3ff39c55-fbdc-4e41-afe1-1c9ad38b58ed"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("ba2fa72a-4c6f-4c7f-9c7c-807688c766ae"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("ba377e80-1e1c-4e1b-9cbf-51c146520511"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5079c7e5-a95e-4922-8adf-3577df24765d"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("61a42a8e-93ff-4a53-922b-5e2eb66da657"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("7b392925-619c-44a1-a694-8428588ed3ca"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("1bd4d92e-d1b5-4af0-a8b5-9aa4542d2668"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("25de5207-1fa2-451a-8457-cd19d102325c"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("191ef286-b9b2-4c3f-b680-e157db84d5db"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3788e2d1-3a2d-4281-89e6-fede139d342e"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f0c82070-4563-4a71-8a73-7beb6c42830e"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("4529e9a6-8c48-418d-a57f-22ddb9ae9a0d"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a0c0cd14-8db2-478b-8db4-92f5d6ae0721"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fb29fa5b-4cd8-42ef-99c0-39960c46dfa0"));

            migrationBuilder.CreateTable(
                name: "DoctorProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorProfiles_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorProfiles_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorProfiles_DoctorID",
                table: "DoctorProfiles",
                column: "DoctorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorProfiles_MemberId",
                table: "DoctorProfiles",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorProfiles");

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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("74f6c753-8e44-4e4e-89e6-f60eac62760f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("715018cd-13d4-4b55-9df3-4d816307a1af"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "a4c2084d-8072-47f4-9cda-742db7fef9b1");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("67cd293f-a5ca-40c9-81c4-82328aadac25"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("b339b7f4-0c36-4509-8abc-2bc7b5d18b13"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("3ff39c55-fbdc-4e41-afe1-1c9ad38b58ed"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("ba2fa72a-4c6f-4c7f-9c7c-807688c766ae"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("a5dd227d-d5fd-497c-86db-de8ec40a6fa6") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("ba377e80-1e1c-4e1b-9cbf-51c146520511"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("5079c7e5-a95e-4922-8adf-3577df24765d"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 6, 55, 51, 867, DateTimeKind.Utc).AddTicks(9342), null, "Islamic University", new DateTime(2028, 10, 3, 12, 55, 51, 867, DateTimeKind.Local).AddTicks(9348), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("61a42a8e-93ff-4a53-922b-5e2eb66da657"), false, "BA", null, null, new DateTime(2023, 10, 3, 6, 55, 51, 867, DateTimeKind.Utc).AddTicks(9373), null, "Rajshahi University", new DateTime(2028, 10, 3, 12, 55, 51, 867, DateTimeKind.Local).AddTicks(9374), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("7b392925-619c-44a1-a694-8428588ed3ca"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("56a4e7cf-d368-4208-b464-8ca3e82d1764") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("1bd4d92e-d1b5-4af0-a8b5-9aa4542d2668"), false, false, false, new Guid("6298d058-d2f1-4cc7-bc20-f3a8b59b86f0"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("25de5207-1fa2-451a-8457-cd19d102325c"), false, false, false, new Guid("2d47ee3e-d803-4567-8ccd-a738a1d0e8a9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("191ef286-b9b2-4c3f-b680-e157db84d5db"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3788e2d1-3a2d-4281-89e6-fede139d342e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("f0c82070-4563-4a71-8a73-7beb6c42830e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("4529e9a6-8c48-418d-a57f-22ddb9ae9a0d"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("98061375-adcf-4a11-9573-19f68ee96dca") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0c0cd14-8db2-478b-8db4-92f5d6ae0721"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 12, 55, 51, 868, DateTimeKind.Local).AddTicks(309), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 18, 55, 51, 868, DateTimeKind.Local).AddTicks(310), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fb29fa5b-4cd8-42ef-99c0-39960c46dfa0"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 12, 55, 51, 868, DateTimeKind.Local).AddTicks(280), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 8, 55, 51, 868, DateTimeKind.Local).AddTicks(282), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

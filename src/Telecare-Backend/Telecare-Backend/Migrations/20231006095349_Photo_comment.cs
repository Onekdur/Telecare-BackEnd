using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Photo_comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("153ec06c-f223-482c-b23f-46a056f57144"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("635415aa-a5b3-498a-8c5b-6ecac36b735d"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("366b5c47-f64c-418d-88a7-119621630e55"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("5f3da148-2347-422e-9b56-79b6503d9733"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("f57557c3-8382-4bea-abde-b11c8a79bf44"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("99a754a7-69f8-4f5d-8d2f-e45d68cc6af9"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("e0455be7-0482-4dc0-9664-22e3e5666888"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("8bbe7eb0-60d2-43c8-bc92-cb7799b202ad"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("a4a3e245-be04-4ca0-bbfc-119ae2930a71"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("f7a1ebeb-f046-482a-9e1b-5ae6158f2683"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("af8ff509-555a-432f-bd3d-6abe91737985"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("b0259817-0de2-4e07-9a40-ea25d124ac33"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("ca96eace-fb9c-4d76-aa60-8ba7fa15d641"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("e1c50543-31a3-4239-8d58-f50cd0027d6c"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("cce359c3-e8b4-4d8a-8a07-9d45c8985f40"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("bb5950a9-9f30-45e4-b3d0-38d5bdaaf8f8"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("e79140bb-57f3-46dd-86ad-1c60418885ae"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("537c140f-8fa2-4c40-b964-a3ba7e78fb1e"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("de612474-b793-48c6-ad3a-e0946595f4ea"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("f6dbb614-351b-404c-a202-c2a55f2aee91"));

            migrationBuilder.CreateTable(
                name: "PhotoComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemmberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoComments_AspNetUsers_MemmberId",
                        column: x => x.MemmberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhotoComments_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("4aac5da9-5184-4133-b63e-d9da24d4d320"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("474a907c-61d3-4dae-8b48-363317bdb755"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "f3f70041-0cec-4590-abf0-0884176de46f");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("20e86837-01cc-4d91-85e3-fdd4d52aef63"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fbf62b66-73cf-4fc3-b5fd-4c4d2f5b9c14"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("34d82b69-e49f-4ade-ad91-f821678b7fe9"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 6, 9, 53, 49, 294, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("91019731-aa8a-4f29-966d-bc25a134a6c8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("9a059467-ac55-46c6-ae9b-4c11373b9303"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("5320252f-82f1-4b3e-9bbf-839d890102ba"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("65abac86-7ea4-43d0-a3d2-7f70558c8b03"), false, "Bsc", null, null, new DateTime(2023, 10, 6, 9, 53, 49, 291, DateTimeKind.Utc).AddTicks(9472), null, "Islamic University", new DateTime(2028, 10, 6, 15, 53, 49, 291, DateTimeKind.Local).AddTicks(9479), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("a321d40e-02cd-4a84-a26b-de68eb5d05fc"), false, "BA", null, null, new DateTime(2023, 10, 6, 9, 53, 49, 291, DateTimeKind.Utc).AddTicks(9506), null, "Rajshahi University", new DateTime(2028, 10, 6, 15, 53, 49, 291, DateTimeKind.Local).AddTicks(9507), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("82f888dd-6929-462d-969b-0bc16351017b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("c482f070-a728-4a2c-8f9a-37d76b8c225c") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("025e550b-e836-4f4e-8d86-f48594cb2379"), false, false, false, new Guid("db4e3be7-b011-41a7-ac01-2813bea3fd23"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("3e0a0895-3a35-4088-995e-aa6f0939f68e"), false, false, false, new Guid("0a1091f8-1835-4f5d-a7d0-85bfca5ae52c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("35243de7-ddf0-41d8-ab39-4a0af08bc711"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "PhotoComments",
                columns: new[] { "Id", "MemmberId", "PhotoId", "Text", "Time" },
                values: new object[] { new Guid("b836bd52-266f-4493-a0cf-69e97dd073d6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), "Very Nice", new DateTime(2023, 10, 6, 15, 53, 49, 297, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"),
                column: "Time",
                value: new DateTime(2023, 10, 6, 15, 53, 49, 296, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[] { new Guid("d15e66db-5486-442c-9607-261cef76b105"), "Good morning friens", new DateTime(2023, 10, 6, 15, 53, 49, 296, DateTimeKind.Local).AddTicks(760), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("72e04de8-aa7d-45b9-be7e-53d0558fdcd7"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("ea114b8a-408f-4e2c-acfd-0d3277ab9a5d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("856e03fb-eb4f-4d3a-a868-64e6d4e3217b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("ee1772af-35ad-4e9f-827f-0562c39e8cf7") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("642d4ea8-4893-4d1e-aa02-2ad8bd9321fd"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 6, 15, 53, 49, 292, DateTimeKind.Local).AddTicks(1269), false, false, null, " Software Enginer", new DateTime(2023, 10, 7, 21, 53, 49, 292, DateTimeKind.Local).AddTicks(1270), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("68a968d8-02e7-4f11-87d6-33058b8143fe"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 6, 15, 53, 49, 292, DateTimeKind.Local).AddTicks(1256), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 7, 11, 53, 49, 292, DateTimeKind.Local).AddTicks(1259), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoComments_MemmberId",
                table: "PhotoComments",
                column: "MemmberId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoComments_PhotoId",
                table: "PhotoComments",
                column: "PhotoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoComments");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("4aac5da9-5184-4133-b63e-d9da24d4d320"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("474a907c-61d3-4dae-8b48-363317bdb755"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("20e86837-01cc-4d91-85e3-fdd4d52aef63"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("fbf62b66-73cf-4fc3-b5fd-4c4d2f5b9c14"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("34d82b69-e49f-4ade-ad91-f821678b7fe9"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("91019731-aa8a-4f29-966d-bc25a134a6c8"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("9a059467-ac55-46c6-ae9b-4c11373b9303"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("5320252f-82f1-4b3e-9bbf-839d890102ba"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("65abac86-7ea4-43d0-a3d2-7f70558c8b03"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("a321d40e-02cd-4a84-a26b-de68eb5d05fc"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("82f888dd-6929-462d-969b-0bc16351017b"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("025e550b-e836-4f4e-8d86-f48594cb2379"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("3e0a0895-3a35-4088-995e-aa6f0939f68e"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("35243de7-ddf0-41d8-ab39-4a0af08bc711"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d15e66db-5486-442c-9607-261cef76b105"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("72e04de8-aa7d-45b9-be7e-53d0558fdcd7"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("ea114b8a-408f-4e2c-acfd-0d3277ab9a5d"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("856e03fb-eb4f-4d3a-a868-64e6d4e3217b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("642d4ea8-4893-4d1e-aa02-2ad8bd9321fd"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("68a968d8-02e7-4f11-87d6-33058b8143fe"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("153ec06c-f223-482c-b23f-46a056f57144"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("635415aa-a5b3-498a-8c5b-6ecac36b735d"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "d423c164-35e1-4c22-ae58-218c86b00662");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("366b5c47-f64c-418d-88a7-119621630e55"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("5f3da148-2347-422e-9b56-79b6503d9733"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("f57557c3-8382-4bea-abde-b11c8a79bf44"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 6, 9, 31, 31, 214, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("99a754a7-69f8-4f5d-8d2f-e45d68cc6af9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("e0455be7-0482-4dc0-9664-22e3e5666888"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("8bbe7eb0-60d2-43c8-bc92-cb7799b202ad"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("a4a3e245-be04-4ca0-bbfc-119ae2930a71"), false, "BA", null, null, new DateTime(2023, 10, 6, 9, 31, 31, 212, DateTimeKind.Utc).AddTicks(9996), null, "Rajshahi University", new DateTime(2028, 10, 6, 15, 31, 31, 212, DateTimeKind.Local).AddTicks(9997), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("f7a1ebeb-f046-482a-9e1b-5ae6158f2683"), false, "Bsc", null, null, new DateTime(2023, 10, 6, 9, 31, 31, 212, DateTimeKind.Utc).AddTicks(9965), null, "Islamic University", new DateTime(2028, 10, 6, 15, 31, 31, 212, DateTimeKind.Local).AddTicks(9969), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("af8ff509-555a-432f-bd3d-6abe91737985"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("2f578233-48b9-485b-88e5-a9bbeefc2580") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("b0259817-0de2-4e07-9a40-ea25d124ac33"), false, false, false, new Guid("d6fe2189-f833-4bae-9395-f678290801ad"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("ca96eace-fb9c-4d76-aa60-8ba7fa15d641"), false, false, false, new Guid("e6870bd4-01e3-40d1-9bda-974192d6ba6e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("e1c50543-31a3-4239-8d58-f50cd0027d6c"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"),
                column: "Time",
                value: new DateTime(2023, 10, 6, 15, 31, 31, 215, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[] { new Guid("cce359c3-e8b4-4d8a-8a07-9d45c8985f40"), "Good morning friens", new DateTime(2023, 10, 6, 15, 31, 31, 215, DateTimeKind.Local).AddTicks(8288), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("bb5950a9-9f30-45e4-b3d0-38d5bdaaf8f8"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("e79140bb-57f3-46dd-86ad-1c60418885ae"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("537c140f-8fa2-4c40-b964-a3ba7e78fb1e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("11b1f0ac-a4b3-44f6-bcad-d0552b8ad71e") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("de612474-b793-48c6-ad3a-e0946595f4ea"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 6, 15, 31, 31, 213, DateTimeKind.Local).AddTicks(980), false, false, null, " Software Enginer", new DateTime(2023, 10, 7, 21, 31, 31, 213, DateTimeKind.Local).AddTicks(981), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("f6dbb614-351b-404c-a202-c2a55f2aee91"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 6, 15, 31, 31, 213, DateTimeKind.Local).AddTicks(969), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 7, 11, 31, 31, 213, DateTimeKind.Local).AddTicks(970), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

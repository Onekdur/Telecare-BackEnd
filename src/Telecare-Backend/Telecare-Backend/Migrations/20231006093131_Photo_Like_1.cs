using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Photo_Like_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoLikes",
                table: "PhotoLikes");

            migrationBuilder.DropIndex(
                name: "IX_PhotoLikes_MemmberId",
                table: "PhotoLikes");

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
                table: "PhotoLikes",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("bfb55932-1648-41ea-831e-91ae622c12ad"));

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhotoLikes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoLikes",
                table: "PhotoLikes",
                columns: new[] { "MemmberId", "PhotoId" });

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

            migrationBuilder.InsertData(
                table: "PhotoLikes",
                columns: new[] { "MemmberId", "PhotoId", "React" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), 0 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoLikes",
                table: "PhotoLikes");

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
                table: "PhotoLikes",
                keyColumns: new[] { "MemmberId", "PhotoId" },
                keyValues: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82") });

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

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PhotoLikes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoLikes",
                table: "PhotoLikes",
                column: "Id");

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
                table: "PhotoLikes",
                columns: new[] { "Id", "MemmberId", "PhotoId", "React" },
                values: new object[] { new Guid("bfb55932-1648-41ea-831e-91ae622c12ad"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), 0 });

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

            migrationBuilder.CreateIndex(
                name: "IX_PhotoLikes_MemmberId",
                table: "PhotoLikes",
                column: "MemmberId");
        }
    }
}

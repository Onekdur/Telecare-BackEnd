using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddBirdateonMember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "PhotoComments",
                keyColumn: "Id",
                keyValue: new Guid("b836bd52-266f-4493-a0cf-69e97dd073d6"));

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

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("393a7ef5-26f7-457d-b41e-702255409acf"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("beddacfa-447c-4fb1-8858-51fabde46a86"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                columns: new[] { "BirthDate", "ConcurrencyStamp" },
                values: new object[] { new DateTime(2000, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "8227f71a-0684-423f-8c4c-7705b78885a3" });

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("26f9e38c-dd7c-4516-bfda-b7af54859208"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("bc79244e-518d-45a9-b9f8-8d9605bef3e3"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("59400014-dcf8-4f7f-bbcf-06ee6ce3440f"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 26, 7, 13, 56, 862, DateTimeKind.Utc).AddTicks(1621) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("cc055452-8730-43fd-b4f1-46ff2162bf90"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("e8db3acb-1f98-403f-81fd-889926547e61"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("20c545c9-999a-4f94-b3b6-dc23eb6b6d68"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("5a88aa2d-c42c-489a-b19a-374bbe1b736e"), false, "BA", null, null, new DateTime(2023, 10, 26, 7, 13, 56, 859, DateTimeKind.Utc).AddTicks(9641), null, "Rajshahi University", new DateTime(2028, 10, 26, 13, 13, 56, 859, DateTimeKind.Local).AddTicks(9641), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("a3416e72-3707-4009-8646-a3514cbe4ce0"), false, "Bsc", null, null, new DateTime(2023, 10, 26, 7, 13, 56, 859, DateTimeKind.Utc).AddTicks(9615), null, "Islamic University", new DateTime(2028, 10, 26, 13, 13, 56, 859, DateTimeKind.Local).AddTicks(9620), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("c4118083-ec70-4e91-868a-5edf4a45c8f0"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("8882bbdf-9bb2-44ad-ae59-357c564813b6") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("17222b29-0eb4-4ff0-b358-9a9846573239"), false, false, false, new Guid("0c71ce99-6acf-4a36-9586-08549be97a97"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("a7839220-c5d3-4204-bce5-af1210b0bc7d"), false, false, false, new Guid("f33b9bb0-e981-4232-942b-0979de43d42d"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("86d0a8e5-7026-4ac8-a761-3f5210b5b94f"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "PhotoComments",
                columns: new[] { "Id", "MemmberId", "PhotoId", "Text", "Time" },
                values: new object[] { new Guid("0e1c1418-8dc1-4e9e-834d-89a889d2fb82"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0e1c1417-8dc1-4e9e-834d-89a889d2fb82"), "Very Nice", new DateTime(2023, 10, 26, 13, 13, 56, 864, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"),
                column: "Time",
                value: new DateTime(2023, 10, 26, 13, 13, 56, 863, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[] { new Guid("14731eea-1c27-4ad5-8f4b-38fa09c18437"), "Good morning friens", new DateTime(2023, 10, 26, 13, 13, 56, 863, DateTimeKind.Local).AddTicks(898), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("4801493c-dfed-4127-b2c0-f2e0eae7950e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("5d71e343-73f4-48f1-a95d-7c4c497ceffd"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("ae18e589-b889-4321-91c5-c5a05525843e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("243b6e97-3f08-4687-816f-46be296184f6") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("cd0d5d93-f443-43c4-a4f0-ea376be23d78"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 26, 13, 13, 56, 860, DateTimeKind.Local).AddTicks(680), false, false, null, " Software Enginer", new DateTime(2023, 10, 27, 19, 13, 56, 860, DateTimeKind.Local).AddTicks(680), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("e498bd91-378d-419b-a6f4-d69e380e71be"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 26, 13, 13, 56, 860, DateTimeKind.Local).AddTicks(614), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 27, 9, 13, 56, 860, DateTimeKind.Local).AddTicks(616), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("393a7ef5-26f7-457d-b41e-702255409acf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("beddacfa-447c-4fb1-8858-51fabde46a86"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("26f9e38c-dd7c-4516-bfda-b7af54859208"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("bc79244e-518d-45a9-b9f8-8d9605bef3e3"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("59400014-dcf8-4f7f-bbcf-06ee6ce3440f"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("cc055452-8730-43fd-b4f1-46ff2162bf90"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("e8db3acb-1f98-403f-81fd-889926547e61"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("20c545c9-999a-4f94-b3b6-dc23eb6b6d68"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5a88aa2d-c42c-489a-b19a-374bbe1b736e"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("a3416e72-3707-4009-8646-a3514cbe4ce0"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("c4118083-ec70-4e91-868a-5edf4a45c8f0"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("17222b29-0eb4-4ff0-b358-9a9846573239"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("a7839220-c5d3-4204-bce5-af1210b0bc7d"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("86d0a8e5-7026-4ac8-a761-3f5210b5b94f"));

            migrationBuilder.DeleteData(
                table: "PhotoComments",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1418-8dc1-4e9e-834d-89a889d2fb82"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("14731eea-1c27-4ad5-8f4b-38fa09c18437"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("4801493c-dfed-4127-b2c0-f2e0eae7950e"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("5d71e343-73f4-48f1-a95d-7c4c497ceffd"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("ae18e589-b889-4321-91c5-c5a05525843e"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("cd0d5d93-f443-43c4-a4f0-ea376be23d78"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e498bd91-378d-419b-a6f4-d69e380e71be"));

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

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
        }
    }
}

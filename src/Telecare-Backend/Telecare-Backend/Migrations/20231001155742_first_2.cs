using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class first_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("5bed83bd-4482-4b90-ba2d-a4f8fc5760f4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("2ea16e3f-4b5b-479b-a8c7-ad00185d6765"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0de8f1fb-6b02-484f-b44a-62dc804b20b6"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("98ec8fd7-df7e-4db1-bcd7-fd618dcc124e"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("c9a795d4-06b3-4ade-9d4f-36554690de8f"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("173596e6-a698-4771-be80-79037d04390e"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("0446a8e5-967a-45d9-bbdc-c3dbf200a3fa"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("3586b28b-35a5-4f44-9f57-acc7d2f48d12"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ace012f5-ba9d-4e19-83a0-8a8aa44e5c61"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("35b90d0d-7f0b-4568-a3a6-8865360119ba"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("caf4b455-c306-41db-b435-1f3ebcd8dadf"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("d6317bb6-6b73-491f-a307-7dfcfe1e0ad0"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("4200489d-827b-49a9-a219-9b7273643908"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("7acf213a-4cab-4c3d-9fa3-f550024f712c"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("06898a89-6b52-4d18-9142-cfb43293f9ba"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("367df816-b5ce-47cd-a7e2-423bdd5fca72"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("cfe4d24b-6e1a-4c61-a2cf-66373f8fbc9b"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("8aa43e71-8b9d-4988-81e6-55c5e367b3c1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("d19be916-7eeb-4fd8-abfe-61d4c7fcd6b5"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "361e88c5-a69d-493f-a34f-8a1b948def95");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("f67bc351-120e-43c6-b660-388097f110ad"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("f8f6dddb-7c60-497c-944d-f51446928156"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("4ab9dba6-5851-4c4a-bd0e-1b1bb8f95e98"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("7144c5cd-3368-4db7-ac58-29d52e41f2db") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("2bc65971-8398-465f-a7d8-b94c1d814c9a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("12975715-8aac-4436-b2cd-2fe392a126d1"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("13a886d3-d722-49a6-9895-7872e560ccab"), false, "BA", null, new DateTime(2023, 10, 1, 15, 57, 42, 307, DateTimeKind.Utc).AddTicks(1000), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 1, 21, 57, 42, 307, DateTimeKind.Local).AddTicks(1001) },
                    { new Guid("88c0b790-b794-4cf8-bef0-57a3d4cba743"), false, "Bsc", null, new DateTime(2023, 10, 1, 15, 57, 42, 307, DateTimeKind.Utc).AddTicks(971), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 1, 21, 57, 42, 307, DateTimeKind.Local).AddTicks(976) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("426dd212-41df-415f-b9e5-c490f5cfb7d6"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("89ad3d8f-a2c1-49c7-9d02-3f15aa17668a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("c9f830d0-13d1-451f-9c60-1ed414657374"), false, false, false, new Guid("451bdf2a-9d7e-4e3c-a20e-f71ea185d7df"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("dd5d3156-c79b-46fa-ba76-2480fff19602"), false, false, false, new Guid("379b2ec8-e772-4f57-bbd8-7e9b9fb30536"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("1c200d11-6e63-4acb-814a-d74b165d06a0"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("ac20abd7-6920-4588-a6ed-ce0541457010"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("bee0c1e1-0e82-45fd-852f-7d6ea3eb0aec"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("763e21ba-696c-4c2a-9f68-9447f04db8e5") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("5a721156-5c40-4ad1-b368-ee2d439f247b"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 10, 1, 21, 57, 42, 307, DateTimeKind.Local).AddTicks(2349), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 3, 57, 42, 307, DateTimeKind.Local).AddTicks(2350) },
                    { new Guid("ee192413-e573-4ad9-8881-f24917f29d09"), "Devskill", false, "Hi this sojib", new DateTime(2023, 10, 1, 21, 57, 42, 307, DateTimeKind.Local).AddTicks(2337), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 2, 17, 57, 42, 307, DateTimeKind.Local).AddTicks(2339) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8aa43e71-8b9d-4988-81e6-55c5e367b3c1"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d19be916-7eeb-4fd8-abfe-61d4c7fcd6b5"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f67bc351-120e-43c6-b660-388097f110ad"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f8f6dddb-7c60-497c-944d-f51446928156"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("4ab9dba6-5851-4c4a-bd0e-1b1bb8f95e98"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("2bc65971-8398-465f-a7d8-b94c1d814c9a"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("12975715-8aac-4436-b2cd-2fe392a126d1"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("13a886d3-d722-49a6-9895-7872e560ccab"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("88c0b790-b794-4cf8-bef0-57a3d4cba743"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("426dd212-41df-415f-b9e5-c490f5cfb7d6"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("c9f830d0-13d1-451f-9c60-1ed414657374"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("dd5d3156-c79b-46fa-ba76-2480fff19602"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("1c200d11-6e63-4acb-814a-d74b165d06a0"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("ac20abd7-6920-4588-a6ed-ce0541457010"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("bee0c1e1-0e82-45fd-852f-7d6ea3eb0aec"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5a721156-5c40-4ad1-b368-ee2d439f247b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ee192413-e573-4ad9-8881-f24917f29d09"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("5bed83bd-4482-4b90-ba2d-a4f8fc5760f4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("2ea16e3f-4b5b-479b-a8c7-ad00185d6765"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "463821ad-16b7-4815-b15b-4be42ff10fdf");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("0de8f1fb-6b02-484f-b44a-62dc804b20b6"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("98ec8fd7-df7e-4db1-bcd7-fd618dcc124e"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("c9a795d4-06b3-4ade-9d4f-36554690de8f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("7f817f02-85d8-4fc5-9d6f-23dbd66a91e2") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("173596e6-a698-4771-be80-79037d04390e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("0446a8e5-967a-45d9-bbdc-c3dbf200a3fa"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("3586b28b-35a5-4f44-9f57-acc7d2f48d12"), false, "BA", null, new DateTime(2023, 10, 1, 15, 43, 28, 341, DateTimeKind.Utc).AddTicks(9777), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 1, 21, 43, 28, 341, DateTimeKind.Local).AddTicks(9778) },
                    { new Guid("ace012f5-ba9d-4e19-83a0-8a8aa44e5c61"), false, "Bsc", null, new DateTime(2023, 10, 1, 15, 43, 28, 341, DateTimeKind.Utc).AddTicks(9745), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 1, 21, 43, 28, 341, DateTimeKind.Local).AddTicks(9749) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("35b90d0d-7f0b-4568-a3a6-8865360119ba"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("c2182067-a621-468d-a455-17682be81b3a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("caf4b455-c306-41db-b435-1f3ebcd8dadf"), false, false, false, new Guid("21c72073-93ef-4cab-a9a6-43f011b3c8a4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("d6317bb6-6b73-491f-a307-7dfcfe1e0ad0"), false, false, false, new Guid("a1633b40-ec8a-4b96-b0d2-d69a69173916"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("4200489d-827b-49a9-a219-9b7273643908"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("7acf213a-4cab-4c3d-9fa3-f550024f712c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("06898a89-6b52-4d18-9142-cfb43293f9ba"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("700a8d59-b72d-4493-9929-7f5b3fa047c2") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("367df816-b5ce-47cd-a7e2-423bdd5fca72"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 10, 1, 21, 43, 28, 342, DateTimeKind.Local).AddTicks(1075), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 3, 43, 28, 342, DateTimeKind.Local).AddTicks(1076) },
                    { new Guid("cfe4d24b-6e1a-4c61-a2cf-66373f8fbc9b"), "Devskill", false, "Hi this sojib", new DateTime(2023, 10, 1, 21, 43, 28, 342, DateTimeKind.Local).AddTicks(1060), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 2, 17, 43, 28, 342, DateTimeKind.Local).AddTicks(1062) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId",
                unique: true,
                filter: "[PatientId] IS NOT NULL");
        }
    }
}

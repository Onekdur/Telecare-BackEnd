using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_work : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_AspNetUsers_MemberId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_MemberId",
                table: "Doctors");

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

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("11617f3a-b851-45e2-9d4a-cf1e297d5a1c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("635d90c2-a3ae-4e39-999c-1b4898c25c00"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "925536f8-6673-49e4-878a-4b052530fb8d");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("466a7a27-1727-4828-ab6a-e9f324e65747"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("dfbb79f8-dc6f-4a98-8812-ae932ae11431"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("d497975a-0ffc-48b2-939b-47522c706e35"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("7e7fdd5a-65fe-459a-a268-4029c157f77b") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("67b2cbcc-a7f1-45c4-be60-8942cc15d658"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("3c253b31-6014-4444-9458-8a7e0b4d7aa4"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("1ed5001b-1e9e-463d-bb3c-d591610399ad"), false, "Bsc", null, new DateTime(2023, 10, 2, 5, 48, 59, 100, DateTimeKind.Utc).AddTicks(9862), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 2, 11, 48, 59, 100, DateTimeKind.Local).AddTicks(9866) },
                    { new Guid("659d8a6c-b4cb-47e8-8a2e-806d4a1e82be"), false, "BA", null, new DateTime(2023, 10, 2, 5, 48, 59, 100, DateTimeKind.Utc).AddTicks(9886), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 2, 11, 48, 59, 100, DateTimeKind.Local).AddTicks(9887) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("1f12daec-1ac6-4f0c-a0a5-2345060c715e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("9e115394-35c1-429b-aa69-5267f91739e8") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("b1ccd6eb-a82e-4e64-9592-f862ad156bfd"), false, false, false, new Guid("ad4d0d15-13dc-4808-bf76-c870fbc6be5a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("ff6ffdfc-7ba4-44a0-b0bf-26056c4e3a26"), false, false, false, new Guid("8790c663-a3d5-46be-8bca-d5639d0dcc27"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("1571deb2-55e3-4855-bd65-bf552015de1a"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("a86ef954-832e-40df-b6c0-0359882d1abe"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("3f0b2a74-1e37-4c2a-9a12-ebe6d920a016"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0ce87d90-a4ba-490d-877a-35b6f6fe00c5") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("1e1f1339-1fb5-4df7-afdc-a9c1b92be1cf"), "Devskill", false, "Hi this sojib", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 11, 48, 59, 101, DateTimeKind.Local).AddTicks(3589), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 3, 7, 48, 59, 101, DateTimeKind.Local).AddTicks(3592) },
                    { new Guid("ceb35df4-17cd-4160-b036-22e0479442d9"), "Vivasoft", false, "Descriptiom", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 11, 48, 59, 101, DateTimeKind.Local).AddTicks(3607), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 17, 48, 59, 101, DateTimeKind.Local).AddTicks(3607) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Works_DoctorId",
                table: "Works",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_MemberId",
                table: "Doctors",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Works_AspNetUsers_MemberId",
                table: "Works",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Doctors_DoctorId",
                table: "Works",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Works_AspNetUsers_MemberId",
                table: "Works");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Doctors_DoctorId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Works_DoctorId",
                table: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_MemberId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("11617f3a-b851-45e2-9d4a-cf1e297d5a1c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("635d90c2-a3ae-4e39-999c-1b4898c25c00"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("466a7a27-1727-4828-ab6a-e9f324e65747"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("dfbb79f8-dc6f-4a98-8812-ae932ae11431"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("d497975a-0ffc-48b2-939b-47522c706e35"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("67b2cbcc-a7f1-45c4-be60-8942cc15d658"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("3c253b31-6014-4444-9458-8a7e0b4d7aa4"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("1ed5001b-1e9e-463d-bb3c-d591610399ad"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("659d8a6c-b4cb-47e8-8a2e-806d4a1e82be"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("1f12daec-1ac6-4f0c-a0a5-2345060c715e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("b1ccd6eb-a82e-4e64-9592-f862ad156bfd"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("ff6ffdfc-7ba4-44a0-b0bf-26056c4e3a26"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("1571deb2-55e3-4855-bd65-bf552015de1a"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("a86ef954-832e-40df-b6c0-0359882d1abe"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("3f0b2a74-1e37-4c2a-9a12-ebe6d920a016"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("1e1f1339-1fb5-4df7-afdc-a9c1b92be1cf"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ceb35df4-17cd-4160-b036-22e0479442d9"));

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Works");

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
                name: "IX_Doctors_MemberId",
                table: "Doctors",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_AspNetUsers_MemberId",
                table: "Works",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

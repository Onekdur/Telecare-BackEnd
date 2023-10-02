using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_work_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Works",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Works",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("1755f4b5-0b8e-45d2-bad7-fef91e143be2"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("b5db635a-bb4a-4107-982e-bbdf1394d6cb"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "0509bb62-37f3-4922-9c07-544f64e777de");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("59f4f776-245f-44ee-a9e9-fcf77c0a969d"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("9f1dcda1-5039-46a9-9a65-429ccea9fcca"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("23ee72d1-bec9-4252-8776-184da27b19e6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("6cdf913d-df8d-41e6-ac63-4a4c3e4a0a96") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("67b0fabc-746e-4ebe-9d3e-1f388bff656e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("c23cd287-8e3f-48b3-a612-a601381bf8db"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("24701a09-ee74-43fd-a41d-e68f1e59a0a7"), false, "BA", null, new DateTime(2023, 10, 2, 5, 52, 41, 410, DateTimeKind.Utc).AddTicks(9342), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 2, 11, 52, 41, 410, DateTimeKind.Local).AddTicks(9343) },
                    { new Guid("684e445e-ebbe-4302-80ff-e32d2ec48ce3"), false, "Bsc", null, new DateTime(2023, 10, 2, 5, 52, 41, 410, DateTimeKind.Utc).AddTicks(9311), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 2, 11, 52, 41, 410, DateTimeKind.Local).AddTicks(9317) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("a8bba3e2-866f-41bc-a832-6eeb4a5d02ac"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("26f94647-c83e-405a-b6b8-445516d695e7") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("427bf13f-cd2e-4075-bf35-4196804e0f2f"), false, false, false, new Guid("be0287b1-1c01-475c-9867-ca14a0ce4d8d"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("6b441c1e-0410-495c-9dc1-42624faedd84"), false, false, false, new Guid("a41df227-70f0-4606-9cae-379df3ceded3"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("26489b55-b469-48aa-bff2-03fbe15cc4db"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("fce276e7-6366-4da2-8a8b-c0b692817491"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("ed7508f0-f985-4e61-ada8-c444fc44361f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0559ee63-2a78-43ed-bdfc-6bf06828c806") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("396f05aa-a998-400e-b13a-54c6efcd2e40"), "Devskill", false, "Hi this sojib", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 11, 52, 41, 411, DateTimeKind.Local).AddTicks(6106), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 3, 7, 52, 41, 411, DateTimeKind.Local).AddTicks(6117) },
                    { new Guid("3ea7e835-c42e-41f9-a207-cfb09e99df7f"), "Vivasoft", false, "Descriptiom", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 11, 52, 41, 411, DateTimeKind.Local).AddTicks(6142), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 17, 52, 41, 411, DateTimeKind.Local).AddTicks(6143) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("1755f4b5-0b8e-45d2-bad7-fef91e143be2"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("b5db635a-bb4a-4107-982e-bbdf1394d6cb"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("59f4f776-245f-44ee-a9e9-fcf77c0a969d"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("9f1dcda1-5039-46a9-9a65-429ccea9fcca"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("23ee72d1-bec9-4252-8776-184da27b19e6"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("67b0fabc-746e-4ebe-9d3e-1f388bff656e"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("c23cd287-8e3f-48b3-a612-a601381bf8db"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("24701a09-ee74-43fd-a41d-e68f1e59a0a7"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("684e445e-ebbe-4302-80ff-e32d2ec48ce3"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("a8bba3e2-866f-41bc-a832-6eeb4a5d02ac"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("427bf13f-cd2e-4075-bf35-4196804e0f2f"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("6b441c1e-0410-495c-9dc1-42624faedd84"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("26489b55-b469-48aa-bff2-03fbe15cc4db"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("fce276e7-6366-4da2-8a8b-c0b692817491"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("ed7508f0-f985-4e61-ada8-c444fc44361f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("396f05aa-a998-400e-b13a-54c6efcd2e40"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("3ea7e835-c42e-41f9-a207-cfb09e99df7f"));

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Works");

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
        }
    }
}

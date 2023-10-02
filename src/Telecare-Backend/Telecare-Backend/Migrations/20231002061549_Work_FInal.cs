using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Work_FInal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("c3aaa3de-4968-4a72-b7db-72496a15908f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("0b83bc69-97b3-4407-8699-fe73ab48bd07"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "3ed51d27-afe5-458d-b710-fb391610345d");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("408f11ad-0307-469c-8cb9-0c090a586acb"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("43644feb-3c7c-47e9-ad6d-747eb7ab084b"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("fae71dda-8076-4f75-a08e-6d6a97f36ecc"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("bc8daa30-dc60-4b45-84dc-e4d398e3d87b") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("d340bd46-baa5-4552-b08f-41e138cd4688"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("9fcbae24-0c7a-4ce3-8411-53bbdaed9e6f"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("a2e2f04c-1344-4fb7-bd34-2f6629fad354"), false, "Bsc", null, new DateTime(2023, 10, 2, 6, 15, 49, 539, DateTimeKind.Utc).AddTicks(9233), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 2, 12, 15, 49, 539, DateTimeKind.Local).AddTicks(9237) },
                    { new Guid("b32084bd-513d-488b-8512-4722b8d15907"), false, "BA", null, new DateTime(2023, 10, 2, 6, 15, 49, 539, DateTimeKind.Utc).AddTicks(9273), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 2, 12, 15, 49, 539, DateTimeKind.Local).AddTicks(9273) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("cfce9b33-1b50-4f4e-b7b4-5f52d332e5e7"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("14aa1033-2d04-4229-b6cc-b12fd098fa13") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("56b2197c-b6ca-455f-b514-754b2001c109"), false, false, false, new Guid("76617866-86bc-4445-bc2e-836bc3d265fb"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("eb620662-6ee8-4b70-84c5-76c5758777f5"), false, false, false, new Guid("83b7b501-f2dc-4b10-b8bb-8db9b4e1fe9f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("86053bc3-f6d5-4c32-a95c-30143cc55a4b"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("f447802a-d573-40fa-bf04-3b8ad92f57f6"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("8214ac38-016b-4e0f-88a9-4d652e469b30"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("dd87783c-0d7b-41da-8f2d-42839eafb9bc") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("63d47c84-dcf3-4998-944e-d3c5422dadf0"), "Devskill", false, "Hi this sojib", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 15, 49, 540, DateTimeKind.Local).AddTicks(2516), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 3, 8, 15, 49, 540, DateTimeKind.Local).AddTicks(2520) },
                    { new Guid("a41ff46a-dd71-4b16-a4f6-3a1e56fa1879"), "Vivasoft", false, "Descriptiom", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 15, 49, 540, DateTimeKind.Local).AddTicks(2532), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 18, 15, 49, 540, DateTimeKind.Local).AddTicks(2533) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c3aaa3de-4968-4a72-b7db-72496a15908f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0b83bc69-97b3-4407-8699-fe73ab48bd07"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("408f11ad-0307-469c-8cb9-0c090a586acb"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("43644feb-3c7c-47e9-ad6d-747eb7ab084b"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("fae71dda-8076-4f75-a08e-6d6a97f36ecc"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("d340bd46-baa5-4552-b08f-41e138cd4688"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("9fcbae24-0c7a-4ce3-8411-53bbdaed9e6f"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("a2e2f04c-1344-4fb7-bd34-2f6629fad354"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("b32084bd-513d-488b-8512-4722b8d15907"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("cfce9b33-1b50-4f4e-b7b4-5f52d332e5e7"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("56b2197c-b6ca-455f-b514-754b2001c109"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("eb620662-6ee8-4b70-84c5-76c5758777f5"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("86053bc3-f6d5-4c32-a95c-30143cc55a4b"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f447802a-d573-40fa-bf04-3b8ad92f57f6"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("8214ac38-016b-4e0f-88a9-4d652e469b30"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("63d47c84-dcf3-4998-944e-d3c5422dadf0"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a41ff46a-dd71-4b16-a4f6-3a1e56fa1879"));

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
    }
}

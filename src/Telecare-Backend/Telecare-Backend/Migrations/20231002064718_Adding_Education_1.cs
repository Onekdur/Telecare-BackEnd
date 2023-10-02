using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Education_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("966b3da0-5916-459b-ac4f-3753cf56600e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("613d2e1d-062f-4bdc-9d2a-e0bcfcd1a27b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("1015bd7c-bf02-4dca-8bae-5737d119c5e6"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("966e00f2-628f-45b8-a406-8531b0d25911"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("513a2a37-b6d6-47da-bfd3-20c9327c0d30"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("e049269c-a293-4642-8111-305c1a202c88"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("60641ebf-078e-455c-b8c8-f581cdcf59d7"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("086663f8-2f1d-4a83-8caa-4348a107e6fa"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5e11e3d8-b363-4791-9831-b6937f0db920"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("1011f81c-9602-47ea-ab3d-8ef84064bf58"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("5bc0786c-f9b3-4f3f-9f1d-9741d91d6404"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("7a45db3b-10b0-435a-91a7-a80f3cda14cf"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("80978e37-97ac-4644-b3f8-e29fa6989323"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f95487d7-c0c9-4fcd-ab54-1319ba47ed9c"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("c6fe9973-abba-4ce3-8f63-a74258223ea9"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("bf708e10-1a8b-4b55-8b05-04d9291eba1b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e2736eb5-9cf0-4a08-9505-35d9f0ea852d"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("2e909c5a-443b-4137-b8e0-57f8b452484c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("92aa791e-026a-4780-9b4e-29926c269d8f"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "399b2d4f-c01f-487f-bd51-daa3b41985ca");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("18356846-47fa-4345-ab3a-c77ded1c139c"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("242048b3-01d8-43e3-a312-aa2c136e9fac"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("a94d50da-c3fb-4fd2-844a-987b50c0dd89"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("3528c93b-d2b9-400b-9bc6-5d2dddd80e16") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("751074ef-7e20-4e39-860a-a62b506fdd49"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("b9a45116-0887-43c0-8ae5-af91c95a4633"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("0c3a4532-a313-4f08-9cd3-54a1d54666b1"), false, "BA", null, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 6, 47, 18, 508, DateTimeKind.Utc).AddTicks(1434), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 2, 12, 47, 18, 508, DateTimeKind.Local).AddTicks(1435), false, false },
                    { new Guid("4f08dc54-81db-44bf-89c9-4aebbf00e9b2"), false, "Bsc", null, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 6, 47, 18, 508, DateTimeKind.Utc).AddTicks(1403), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 2, 12, 47, 18, 508, DateTimeKind.Local).AddTicks(1407), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("9830cd71-ea7e-48ce-91e4-eb88c91a6ba4"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("6a1688b7-9070-419f-b194-3ff88d4c48fd") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("12f571c3-f605-42d3-b352-d8bd2b5ac93f"), false, false, false, new Guid("17faa46f-ab0f-4279-95c9-32865ece2ce1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("cf37a5c1-55a6-45a7-ad47-1c3c03a74be7"), false, false, false, new Guid("5363b9e0-c89c-4fdf-8570-822d9ac9f097"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("23f344c0-6fcf-4736-9b31-c51d7ddffad1"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("7d546b78-645f-4fad-837b-00b54e2d2118"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("c8df04f6-b3f3-47a8-8c03-b29d6c5d7921"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("073be6b3-3b02-4627-ab04-bc1b83ce247f") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("7f813079-5003-43f8-b36c-06ba416db1b4"), "Vivasoft", false, "Descriptiom", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 47, 18, 508, DateTimeKind.Local).AddTicks(5116), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 18, 47, 18, 508, DateTimeKind.Local).AddTicks(5117) },
                    { new Guid("de71caf0-6c1d-4bd9-9a92-b2949b596c84"), "Devskill", false, "Hi this sojib", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 47, 18, 508, DateTimeKind.Local).AddTicks(5098), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 3, 8, 47, 18, 508, DateTimeKind.Local).AddTicks(5102) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2e909c5a-443b-4137-b8e0-57f8b452484c"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("92aa791e-026a-4780-9b4e-29926c269d8f"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("18356846-47fa-4345-ab3a-c77ded1c139c"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("242048b3-01d8-43e3-a312-aa2c136e9fac"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("a94d50da-c3fb-4fd2-844a-987b50c0dd89"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("751074ef-7e20-4e39-860a-a62b506fdd49"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("b9a45116-0887-43c0-8ae5-af91c95a4633"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("0c3a4532-a313-4f08-9cd3-54a1d54666b1"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4f08dc54-81db-44bf-89c9-4aebbf00e9b2"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("9830cd71-ea7e-48ce-91e4-eb88c91a6ba4"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("12f571c3-f605-42d3-b352-d8bd2b5ac93f"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("cf37a5c1-55a6-45a7-ad47-1c3c03a74be7"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("23f344c0-6fcf-4736-9b31-c51d7ddffad1"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("7d546b78-645f-4fad-837b-00b54e2d2118"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("c8df04f6-b3f3-47a8-8c03-b29d6c5d7921"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("7f813079-5003-43f8-b36c-06ba416db1b4"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("de71caf0-6c1d-4bd9-9a92-b2949b596c84"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("966b3da0-5916-459b-ac4f-3753cf56600e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("613d2e1d-062f-4bdc-9d2a-e0bcfcd1a27b"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "901cf8d1-f361-4ac6-8f19-8746e94b31c5");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("1015bd7c-bf02-4dca-8bae-5737d119c5e6"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("966e00f2-628f-45b8-a406-8531b0d25911"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("513a2a37-b6d6-47da-bfd3-20c9327c0d30"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("28609c15-8a2d-4b08-9629-83c4ea72cd0f") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("e049269c-a293-4642-8111-305c1a202c88"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("60641ebf-078e-455c-b8c8-f581cdcf59d7"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("086663f8-2f1d-4a83-8caa-4348a107e6fa"), false, "Bsc", null, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 6, 42, 4, 864, DateTimeKind.Utc).AddTicks(3496), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 2, 12, 42, 4, 864, DateTimeKind.Local).AddTicks(3500), false, false },
                    { new Guid("5e11e3d8-b363-4791-9831-b6937f0db920"), false, "BA", null, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 6, 42, 4, 864, DateTimeKind.Utc).AddTicks(3551), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 2, 12, 42, 4, 864, DateTimeKind.Local).AddTicks(3551), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("1011f81c-9602-47ea-ab3d-8ef84064bf58"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("d7abce80-93ea-4a93-a506-f0c397f8321e") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("5bc0786c-f9b3-4f3f-9f1d-9741d91d6404"), false, false, false, new Guid("982fb7ed-efcb-493c-9651-1bc1b22ba5ec"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("7a45db3b-10b0-435a-91a7-a80f3cda14cf"), false, false, false, new Guid("ca770d9e-3fcb-4ffe-8a5c-7f13ab6389a4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("80978e37-97ac-4644-b3f8-e29fa6989323"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("f95487d7-c0c9-4fcd-ab54-1319ba47ed9c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("c6fe9973-abba-4ce3-8f63-a74258223ea9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("8e036380-cb4d-46d1-b04f-36c1c24a0aa5") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("bf708e10-1a8b-4b55-8b05-04d9291eba1b"), "Vivasoft", false, "Descriptiom", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 42, 4, 864, DateTimeKind.Local).AddTicks(7236), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 3, 18, 42, 4, 864, DateTimeKind.Local).AddTicks(7237) },
                    { new Guid("e2736eb5-9cf0-4a08-9505-35d9f0ea852d"), "Devskill", false, "Hi this sojib", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new DateTime(2023, 10, 2, 12, 42, 4, 864, DateTimeKind.Local).AddTicks(7216), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 3, 8, 42, 4, 864, DateTimeKind.Local).AddTicks(7220) }
                });
        }
    }
}

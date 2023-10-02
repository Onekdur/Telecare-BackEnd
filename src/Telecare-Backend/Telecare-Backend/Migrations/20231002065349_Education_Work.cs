using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Education_Work : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "MemberId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "MemberId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("c4faf45b-acaa-4a38-b3b6-2e7c9b3d4454"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("625b050c-debf-43e1-a4ae-1c66716c062a"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "1ec80613-5590-4ef9-87a1-f7c11c941ddc");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("286b3113-01ce-4a2d-b313-ca42ecdfd733"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fbb0cab3-2a82-4dfc-8449-e920ff1e3094"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("93f4e6cf-4129-451f-ac9b-07185bf6da0a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("7e1aa313-32d3-4d3b-b47d-5eb7dc7dd362") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("783cc230-496d-4dff-abd3-a8fff4d07b54"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("723b9d02-c0d7-4052-b268-86c878154922"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("0ecac5b9-cc92-49fd-859a-cbfe4e65caa0"), false, "BA", null, null, new DateTime(2023, 10, 2, 6, 53, 49, 288, DateTimeKind.Utc).AddTicks(4472), null, "Rajshahi University", new DateTime(2028, 10, 2, 12, 53, 49, 288, DateTimeKind.Local).AddTicks(4472), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("37601fff-981a-4e57-9e37-52f96a6552e8"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 6, 53, 49, 288, DateTimeKind.Utc).AddTicks(4445), null, "Islamic University", new DateTime(2028, 10, 2, 12, 53, 49, 288, DateTimeKind.Local).AddTicks(4450), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("7e7020cd-5720-4766-928f-403c18b7e370"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("208b1842-c6d5-41d0-a4b1-c7eba12ff602") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("488cb676-ee04-4807-ab08-9d729e42d6f7"), false, false, false, new Guid("ff7ee4aa-eb62-4295-9356-e5c481da26b3"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("6e2b6dcb-b7f9-49d1-8094-662a42163323"), false, false, false, new Guid("c1f8de60-8a3d-414b-94b2-440aa73782ca"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("6ba72d48-4eed-41ca-a87e-42d057153b5d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("d1f039c0-6127-4457-b893-a0aed6d3488f"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("d701a513-4d86-4f09-b616-6a31bfad1d88"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("4b4211c0-704e-4f21-aa29-fc735ff30e84") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("21785773-92d6-4511-bea6-743d9b092c31"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 12, 53, 49, 288, DateTimeKind.Local).AddTicks(5353), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 8, 53, 49, 288, DateTimeKind.Local).AddTicks(5354), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("f874a8bf-bcb1-4702-b712-1e26e5ac78ff"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 12, 53, 49, 288, DateTimeKind.Local).AddTicks(5364), false, false, null, " Software Enginer", new DateTime(2023, 10, 3, 18, 53, 49, 288, DateTimeKind.Local).AddTicks(5364), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("c4faf45b-acaa-4a38-b3b6-2e7c9b3d4454"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("625b050c-debf-43e1-a4ae-1c66716c062a"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("286b3113-01ce-4a2d-b313-ca42ecdfd733"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("fbb0cab3-2a82-4dfc-8449-e920ff1e3094"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("93f4e6cf-4129-451f-ac9b-07185bf6da0a"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("783cc230-496d-4dff-abd3-a8fff4d07b54"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("723b9d02-c0d7-4052-b268-86c878154922"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("0ecac5b9-cc92-49fd-859a-cbfe4e65caa0"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("37601fff-981a-4e57-9e37-52f96a6552e8"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("7e7020cd-5720-4766-928f-403c18b7e370"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("488cb676-ee04-4807-ab08-9d729e42d6f7"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("6e2b6dcb-b7f9-49d1-8094-662a42163323"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("6ba72d48-4eed-41ca-a87e-42d057153b5d"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("d1f039c0-6127-4457-b893-a0aed6d3488f"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("d701a513-4d86-4f09-b616-6a31bfad1d88"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("21785773-92d6-4511-bea6-743d9b092c31"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("f874a8bf-bcb1-4702-b712-1e26e5ac78ff"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Works");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Educations");

            migrationBuilder.AlterColumn<Guid>(
                name: "MemberId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MemberId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
    }
}

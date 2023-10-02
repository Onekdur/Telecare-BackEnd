using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Adding_Education : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_AspNetUsers_MemberId",
                table: "Educations");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Educations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "isDelete",
                table: "Educations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isPrivate",
                table: "Educations",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.CreateIndex(
                name: "IX_Educations_DoctorId",
                table: "Educations",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_AspNetUsers_MemberId",
                table: "Educations",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Doctors_DoctorId",
                table: "Educations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_AspNetUsers_MemberId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Doctors_DoctorId",
                table: "Educations");

            migrationBuilder.DropIndex(
                name: "IX_Educations_DoctorId",
                table: "Educations");

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

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "isPrivate",
                table: "Educations");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "Works",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_AspNetUsers_MemberId",
                table: "Educations",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Doctorpatient_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2311db32-e119-4df4-99bd-bcfe5dfe7f8e"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e14b8391-40ea-485a-917e-8878627671cb"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0a2f5d0c-27b1-4864-93ee-9ef85de95e08"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0fbb4405-6f66-42d7-8090-2e4f783708ec"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("2d35c6db-cba0-4fe8-a5f2-088fe0d337f5"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("d472dfe8-7ad1-4c5b-8f59-87a5f3404f83"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("194dce1c-0796-4ec2-9f65-9423030ac81a"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("fba0c4f0-fd6d-4378-a662-1cc3783a2086"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("5358b5d2-cc9a-4cbb-9beb-4f03aec349a5"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("2fe6e77d-50bd-47e6-8e54-fbc5a9f069a8"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("a8b9547a-de73-47cc-9738-694a5964eb09"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("2e2d8a5a-7f8a-4a0d-a79f-91edc6f6dbf2"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("2f350f83-3d04-4280-b6bf-cae1468b993d"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("a88f0822-ec65-45df-bb2c-1aac1b67cc3d"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("9b979430-516d-4e56-b457-caf35551e550"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("c91b34bd-b3e0-4dfd-8e66-64ea4dbb209e"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("2d92ee4d-da3a-4ed7-a051-7c540fbc49ad"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("9dabcd9e-1747-424c-93d1-38625214fe68"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "88c1d2a5-3fb5-4557-ae78-4d9f6ad2b08c");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("29d80e6a-d110-4818-9601-70262b3b052d"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("418034c4-bef4-4a84-893a-37d4ff30640e"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("91910c3e-f694-4ad1-9d07-bd5bfbea1728"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("d4bb39c4-d157-4a47-bf44-0ce8b098fcdd") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("d16ff95b-2808-4e68-9909-53398d9801eb"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("32cdd601-f555-4913-9d6f-e9b3a9985797"), false, "BA", null, new DateTime(2023, 10, 1, 3, 2, 24, 218, DateTimeKind.Utc).AddTicks(7522), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 1, 9, 2, 24, 218, DateTimeKind.Local).AddTicks(7522) },
                    { new Guid("5d400d0d-fde6-41c1-ac56-2401598514dd"), false, "Bsc", null, new DateTime(2023, 10, 1, 3, 2, 24, 218, DateTimeKind.Utc).AddTicks(7494), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 1, 9, 2, 24, 218, DateTimeKind.Local).AddTicks(7499) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("3b33ac9d-5606-4c48-9dd2-a956c7d474e6"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("ef2f05e9-049a-4130-8a68-62e9d934a2a0") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("13ae35c6-d610-4fee-bcf0-625e603c6052"), false, false, false, new Guid("96f24c74-e6be-44f6-bf05-9d9ddb27df3b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("5b69ac1e-0524-4087-84e1-0bf96d0cc370"), false, false, false, new Guid("ec4dc4b7-1b06-47e2-b391-5a82e94bafe9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3d3525a5-5a74-44bb-b66f-032a6db7dbf0"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("703b7a7b-6804-4fd0-a1e3-669a1a9760ac"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("756b34bc-f801-48a3-a070-a6fad879452b"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("7d189c0b-8c13-4d77-8184-2ac89774efa0") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("339c3971-fed2-479e-904d-d7d9077fe41b"), "Devskill", false, "Hi this sojib", new DateTime(2023, 10, 1, 9, 2, 24, 218, DateTimeKind.Local).AddTicks(9155), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 2, 5, 2, 24, 218, DateTimeKind.Local).AddTicks(9157) },
                    { new Guid("33df079d-0183-4544-9420-39bc0eb26548"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 10, 1, 9, 2, 24, 218, DateTimeKind.Local).AddTicks(9167), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 2, 15, 2, 24, 218, DateTimeKind.Local).AddTicks(9168) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2d92ee4d-da3a-4ed7-a051-7c540fbc49ad"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("9dabcd9e-1747-424c-93d1-38625214fe68"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("29d80e6a-d110-4818-9601-70262b3b052d"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("418034c4-bef4-4a84-893a-37d4ff30640e"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("91910c3e-f694-4ad1-9d07-bd5bfbea1728"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("d16ff95b-2808-4e68-9909-53398d9801eb"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("32cdd601-f555-4913-9d6f-e9b3a9985797"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5d400d0d-fde6-41c1-ac56-2401598514dd"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("3b33ac9d-5606-4c48-9dd2-a956c7d474e6"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("13ae35c6-d610-4fee-bcf0-625e603c6052"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("5b69ac1e-0524-4087-84e1-0bf96d0cc370"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3d3525a5-5a74-44bb-b66f-032a6db7dbf0"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("703b7a7b-6804-4fd0-a1e3-669a1a9760ac"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("756b34bc-f801-48a3-a070-a6fad879452b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("339c3971-fed2-479e-904d-d7d9077fe41b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("33df079d-0183-4544-9420-39bc0eb26548"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("2311db32-e119-4df4-99bd-bcfe5dfe7f8e"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("e14b8391-40ea-485a-917e-8878627671cb"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "fa73247c-577a-4295-8e5b-1d39c5599061");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("0a2f5d0c-27b1-4864-93ee-9ef85de95e08"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("0fbb4405-6f66-42d7-8090-2e4f783708ec"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("2d35c6db-cba0-4fe8-a5f2-088fe0d337f5"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("ca82d6c2-5514-4ddf-915c-4f320ef5096c") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("d472dfe8-7ad1-4c5b-8f59-87a5f3404f83"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("194dce1c-0796-4ec2-9f65-9423030ac81a"), false, "Bsc", null, new DateTime(2023, 10, 1, 3, 0, 2, 822, DateTimeKind.Utc).AddTicks(8275), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(8278) },
                    { new Guid("fba0c4f0-fd6d-4378-a662-1cc3783a2086"), false, "BA", null, new DateTime(2023, 10, 1, 3, 0, 2, 822, DateTimeKind.Utc).AddTicks(8300), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(8301) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("5358b5d2-cc9a-4cbb-9beb-4f03aec349a5"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("757b4908-4e8f-4b2e-b662-a6bee90f2687") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("2fe6e77d-50bd-47e6-8e54-fbc5a9f069a8"), false, false, false, new Guid("9e59833a-af34-4ad4-aba9-6f22005002c5"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("a8b9547a-de73-47cc-9738-694a5964eb09"), false, false, false, new Guid("86dc471b-0a41-440e-af63-8a2d4212231f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("2e2d8a5a-7f8a-4a0d-a79f-91edc6f6dbf2"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("2f350f83-3d04-4280-b6bf-cae1468b993d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("a88f0822-ec65-45df-bb2c-1aac1b67cc3d"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("bcf2955b-7393-4e70-ae16-a2e95a94934e") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("9b979430-516d-4e56-b457-caf35551e550"), "Devskill", false, "Hi this sojib", new DateTime(2023, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(9253), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 2, 5, 0, 2, 822, DateTimeKind.Local).AddTicks(9255) },
                    { new Guid("c91b34bd-b3e0-4dfd-8e66-64ea4dbb209e"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(9264), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 2, 15, 0, 2, 822, DateTimeKind.Local).AddTicks(9265) }
                });
        }
    }
}

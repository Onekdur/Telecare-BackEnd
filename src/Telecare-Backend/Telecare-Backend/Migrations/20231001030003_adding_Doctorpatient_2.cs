using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Doctorpatient_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("657c2035-8fe0-4c8f-83fb-04c935588ecf"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4229ecf8-df45-4276-bdaa-0f0b36218f64"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3713244f-4c4c-4537-a85b-7f7fec61a1ea"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("f7ef952a-d413-4567-a3a1-4082a45e8b6f"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("094bade1-bb1f-49b4-8f20-0f7889d8fe01"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("43c860e1-17c4-46bf-b442-fa222db1def4"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("539532b8-ff64-49bb-ba87-bc4cbaa9b4d7"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("62465db8-7ee3-4469-93e6-37f9f210bcf8"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("c09b0d5d-63fb-4a07-897a-ae369046e6b3"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("2b084518-5477-4c67-b7fb-927329b87b0e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("b1061efc-c31a-4764-a7c5-67a116a56116"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f31494d9-964b-42f5-8b65-21b48fbbf9d4"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f3da9e7c-2374-4312-bb78-0ccbcdd641af"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("463c06af-9801-44ab-9a80-97861041a991"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("860d83e4-6061-433c-bebc-6d4176c2135c"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ce5b83a3-c167-4f3b-84aa-552476d75e8d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("657c2035-8fe0-4c8f-83fb-04c935588ecf"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("4229ecf8-df45-4276-bdaa-0f0b36218f64"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "2ef3872d-7e89-42aa-bd44-16a53b714c26");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("3713244f-4c4c-4537-a85b-7f7fec61a1ea"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("f7ef952a-d413-4567-a3a1-4082a45e8b6f"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("094bade1-bb1f-49b4-8f20-0f7889d8fe01"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("b82a6567-4380-48dc-9979-b1885c530370") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("43c860e1-17c4-46bf-b442-fa222db1def4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("539532b8-ff64-49bb-ba87-bc4cbaa9b4d7"), false, "BA", null, new DateTime(2023, 10, 1, 2, 52, 24, 648, DateTimeKind.Utc).AddTicks(9119), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 10, 1, 8, 52, 24, 648, DateTimeKind.Local).AddTicks(9119) },
                    { new Guid("62465db8-7ee3-4469-93e6-37f9f210bcf8"), false, "Bsc", null, new DateTime(2023, 10, 1, 2, 52, 24, 648, DateTimeKind.Utc).AddTicks(9087), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 10, 1, 8, 52, 24, 648, DateTimeKind.Local).AddTicks(9093) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("c09b0d5d-63fb-4a07-897a-ae369046e6b3"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("0a3c120b-9eb2-4f3d-8ae4-cfca53becb9c") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("2b084518-5477-4c67-b7fb-927329b87b0e"), false, false, false, new Guid("35468bd1-7383-4288-8969-26fe5308ad11"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("b1061efc-c31a-4764-a7c5-67a116a56116"), false, false, false, new Guid("1284bf9c-a108-48c7-a6a5-4bbbe887ae76"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("f31494d9-964b-42f5-8b65-21b48fbbf9d4"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("f3da9e7c-2374-4312-bb78-0ccbcdd641af"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("463c06af-9801-44ab-9a80-97861041a991"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("d22304f6-a271-4bb9-bd1c-c0bdb6e4c993") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("860d83e4-6061-433c-bebc-6d4176c2135c"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 10, 1, 8, 52, 24, 649, DateTimeKind.Local).AddTicks(133), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 2, 14, 52, 24, 649, DateTimeKind.Local).AddTicks(133) },
                    { new Guid("ce5b83a3-c167-4f3b-84aa-552476d75e8d"), "Devskill", false, "Hi this sojib", new DateTime(2023, 10, 1, 8, 52, 24, 649, DateTimeKind.Local).AddTicks(113), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 2, 4, 52, 24, 649, DateTimeKind.Local).AddTicks(115) }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class First_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorFollowers",
                table: "DoctorFollowers");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("3a4d4878-fb0e-4c24-8a66-833fd8a0dcb1"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("0bb523d6-ef80-445f-9f02-0df2c2cde31c"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("38212cc4-b771-4e4a-a34b-c82ff1fabd8a"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b0499569-e8cc-4200-84b5-73e214725ae8"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("506a93f0-d016-4c6d-b1e7-f9f5d4018287"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumns: new[] { "DoctorId", "FollowerId" },
                keyValues: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("0dae1e22-50ee-49ed-80b6-71806c7e16c7"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("0d2a95af-6bf0-4935-9f08-20c36245226e"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("1b0374a2-5553-42e3-9bd1-87ac4c7f8c3e"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("82be4b01-b96d-4c01-8913-3571dc6c25f5"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("ee0285f3-1a34-42d8-83ec-9c9ef82d0a51"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("703c2cea-50db-4390-8fc2-287ef238da3d"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("8c17f1dd-87ef-478f-a910-755dc84f1419"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("ac91d96f-4d44-4919-9304-6168ead6a225"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f8942e0b-8b0b-4403-a1c0-dfe12de2a5fb"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("ba543316-6b3c-4b42-9387-75520c73afb8"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("2871fc75-d7a7-4f5e-928e-3fccca03d030"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("2fe80af9-c18f-40bc-be70-b991cdf5da39"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "DoctorFollowers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorFollowers",
                table: "DoctorFollowers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("61dd0e1b-a8c1-4adc-8ffe-23eb9b795b73"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("4c843adc-4c33-4987-be69-1e0f41537f3b"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "5d9b3dec-6bb9-4775-a4d3-9e1d689d65b1");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("090cc4d4-a604-4f8f-98bd-5f60d5306a70"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("925df8f2-5863-434d-88cb-9f97aea02deb"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("b12c6ee8-766a-4246-9983-b7c1e06d2e3e"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 12, 54, 25, 729, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("0b96a83d-454c-4a5d-a939-ce569f54ed56"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("9f8cdcbd-4244-40e9-8303-e8c2b4feb0ea"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("61e904cc-691f-4e16-8019-4cafacf6d648"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("17e5f501-468d-4c94-994e-cce9bff703fc"), false, "BA", null, null, new DateTime(2023, 10, 3, 12, 54, 25, 727, DateTimeKind.Utc).AddTicks(3230), null, "Rajshahi University", new DateTime(2028, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(3231), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("4165d980-446e-4315-ae7e-1a7862436a05"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 12, 54, 25, 727, DateTimeKind.Utc).AddTicks(3167), null, "Islamic University", new DateTime(2028, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(3200), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("64f87be0-0f96-4519-afff-18db9a0d3248"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("c8ac8698-7fa0-4424-b493-1748035dda70") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("591c3c89-2a05-4514-bc29-bcb191693875"), false, false, false, new Guid("40676daf-cc0b-4219-82dc-ae42457863bc"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("8b4c5ef3-6820-4b88-92f1-73d8c9b5f036"), false, false, false, new Guid("8c415d2e-7064-4792-8a5f-69fa5c7e66fe"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3edb54ab-9f19-45f6-a3ac-ec844a40c5a2"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("e54190cd-ae5f-4085-a877-a50397238c64"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("fb561be0-5a45-46c1-bbb2-c1a8c14d46a6"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("03b9472b-f93a-4fa2-98ca-332f1cec8262") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5e757059-3a39-43e5-8ced-33ddb151d7e7"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(4231), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 0, 54, 25, 727, DateTimeKind.Local).AddTicks(4232), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fdf9ba3e-6542-4315-9252-b7c4ede8f8b6"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 18, 54, 25, 727, DateTimeKind.Local).AddTicks(4219), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 14, 54, 25, 727, DateTimeKind.Local).AddTicks(4221), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorFollowers_FollowerId",
                table: "DoctorFollowers",
                column: "FollowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorFollowers",
                table: "DoctorFollowers");

            migrationBuilder.DropIndex(
                name: "IX_DoctorFollowers_FollowerId",
                table: "DoctorFollowers");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("61dd0e1b-a8c1-4adc-8ffe-23eb9b795b73"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4c843adc-4c33-4987-be69-1e0f41537f3b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("090cc4d4-a604-4f8f-98bd-5f60d5306a70"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("925df8f2-5863-434d-88cb-9f97aea02deb"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("b12c6ee8-766a-4246-9983-b7c1e06d2e3e"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyColumnType: "uniqueidentifier",
                keyValue: new Guid("0b96a83d-454c-4a5d-a939-ce569f54ed56"));

            migrationBuilder.DeleteData(
                table: "DoctorProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9f8cdcbd-4244-40e9-8303-e8c2b4feb0ea"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("61e904cc-691f-4e16-8019-4cafacf6d648"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("17e5f501-468d-4c94-994e-cce9bff703fc"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4165d980-446e-4315-ae7e-1a7862436a05"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("64f87be0-0f96-4519-afff-18db9a0d3248"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("591c3c89-2a05-4514-bc29-bcb191693875"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("8b4c5ef3-6820-4b88-92f1-73d8c9b5f036"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3edb54ab-9f19-45f6-a3ac-ec844a40c5a2"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("e54190cd-ae5f-4085-a877-a50397238c64"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("fb561be0-5a45-46c1-bbb2-c1a8c14d46a6"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5e757059-3a39-43e5-8ced-33ddb151d7e7"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fdf9ba3e-6542-4315-9252-b7c4ede8f8b6"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DoctorFollowers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorFollowers",
                table: "DoctorFollowers",
                columns: new[] { "FollowerId", "DoctorId" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("3a4d4878-fb0e-4c24-8a66-833fd8a0dcb1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("0bb523d6-ef80-445f-9f02-0df2c2cde31c"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "98007163-1a61-4f6e-89ea-0b70d685c733");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("38212cc4-b771-4e4a-a34b-c82ff1fabd8a"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("b0499569-e8cc-4200-84b5-73e214725ae8"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "MemberId", "Time" },
                values: new object[] { new Guid("506a93f0-d016-4c6d-b1e7-f9f5d4018287"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 3, 12, 42, 51, 551, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "DoctorId", "FollowerId" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "Id", "DoctorID", "MemberId" },
                values: new object[] { new Guid("0dae1e22-50ee-49ed-80b6-71806c7e16c7"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("0d2a95af-6bf0-4935-9f08-20c36245226e"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("1b0374a2-5553-42e3-9bd1-87ac4c7f8c3e"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 12, 42, 51, 549, DateTimeKind.Utc).AddTicks(9642), null, "Islamic University", new DateTime(2028, 10, 3, 18, 42, 51, 549, DateTimeKind.Local).AddTicks(9647), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("82be4b01-b96d-4c01-8913-3571dc6c25f5"), false, "BA", null, null, new DateTime(2023, 10, 3, 12, 42, 51, 549, DateTimeKind.Utc).AddTicks(9670), null, "Rajshahi University", new DateTime(2028, 10, 3, 18, 42, 51, 549, DateTimeKind.Local).AddTicks(9670), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("ee0285f3-1a34-42d8-83ec-9c9ef82d0a51"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("98a70078-69a3-4862-9096-b4a8387cdab5") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("703c2cea-50db-4390-8fc2-287ef238da3d"), false, false, false, new Guid("df5754b2-018d-42e2-a9a0-c9d9dd7e9793"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("8c17f1dd-87ef-478f-a910-755dc84f1419"), false, false, false, new Guid("75e1c9b8-8e2e-46ac-99d3-f0f4aadd550c"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("ac91d96f-4d44-4919-9304-6168ead6a225"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("f8942e0b-8b0b-4403-a1c0-dfe12de2a5fb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("ba543316-6b3c-4b42-9387-75520c73afb8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("fc58f484-3dc5-45b1-9204-2ccbbba94116") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("2871fc75-d7a7-4f5e-928e-3fccca03d030"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 18, 42, 51, 550, DateTimeKind.Local).AddTicks(701), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 14, 42, 51, 550, DateTimeKind.Local).AddTicks(702), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("2fe80af9-c18f-40bc-be70-b991cdf5da39"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 18, 42, 51, 550, DateTimeKind.Local).AddTicks(712), false, false, null, " Software Enginer", new DateTime(2023, 10, 5, 0, 42, 51, 550, DateTimeKind.Local).AddTicks(713), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });
        }
    }
}

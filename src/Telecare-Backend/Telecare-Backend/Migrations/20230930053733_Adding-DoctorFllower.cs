using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddingDoctorFllower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("cf38b56a-fe1d-40fa-b785-57c726b99747"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("4964b6c5-2840-4b75-8471-952b517b233a"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("a06ed4fd-22dc-4c2e-a5e7-05dfa2588025"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("af33c10b-5449-4edc-a0a9-4088d8e1c7e1"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("2be503e2-3c46-485d-b768-6ee09c106792"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("7fb9d679-9bb5-4f70-ade2-bf600a559a08"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("c554b50c-bde1-4318-819f-6e4c366e4aae"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("18bf68ca-87d3-4eb6-996a-b799aeac2c03"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("ee55e66b-55d1-4b71-98d3-d52ecfb7a794"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("f5cb465d-037a-4e5c-a570-712d2acb2fe4"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("314e6138-f9fc-4d9f-8644-aadfae83958d"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("eac93320-7bd0-44be-a898-7cfb472f0cbb"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("f65e342a-e2d2-4b5d-89b2-72e16d70bf91"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("740acb6c-f9ff-492c-9823-b13a4dae1f4f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("e25f4acd-c96a-4e82-b6e4-a7bf59e9d9cc"));

            migrationBuilder.CreateTable(
                name: "DoctorFollowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorFollowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorFollowers_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("b2e95a94-7d09-40e2-86b3-bfd039f914e5"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("46f179b2-34b3-41c6-afcc-eda71423a1dd"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "018a3654-971e-49b1-bac9-b216a4288906");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("18f8f760-2ef1-4a5a-af47-733041085420"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ff73a9cb-ed46-46a1-a9d9-451491c42be5"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "FollowerId", "MemberId" },
                values: new object[] { new Guid("52276895-3d2b-4553-bcaf-d23f0d44cacf"), new Guid("5768c201-bff4-4ccf-9999-891f8bc0f8e7"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("747ac2ce-8154-4eac-9fbe-791f3f03bc93"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("57d5e596-42f9-4571-ab20-0b6146d2ea3c"), false, "Bsc", null, new DateTime(2023, 9, 30, 5, 37, 33, 559, DateTimeKind.Utc).AddTicks(2241), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 30, 11, 37, 33, 559, DateTimeKind.Local).AddTicks(2247) },
                    { new Guid("aa24c268-d12b-44ab-957a-e60b12904da4"), false, "BA", null, new DateTime(2023, 9, 30, 5, 37, 33, 559, DateTimeKind.Utc).AddTicks(2268), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 30, 11, 37, 33, 559, DateTimeKind.Local).AddTicks(2268) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("8602c5dd-bf2b-42ca-9842-b3294ef39c21"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("14782e97-afd7-4a3d-b99c-4f6f5002711c") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("7ae03e38-c534-4704-8be1-4309205fa59d"), false, false, false, new Guid("2913b2b5-dab5-407d-a9bf-6746a2245e73"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("b77acc8a-187b-4b19-a03e-e0920b8cea6f"), false, false, false, new Guid("5907a267-fe96-4533-b1fa-5ce85801e102"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("2ff78438-0542-4fa0-b3f4-1ba20fc9b53e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("c5190d8b-f1ea-445e-8a7c-c46b4b5d5a54"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("85bb5ba6-f7c6-4098-8b4b-d53756507777"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("ba4d5fc3-6e70-4c77-a65c-362b5954234c") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("db52b6c9-ffc3-4905-a03d-87f7cc004f02"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 30, 11, 37, 33, 559, DateTimeKind.Local).AddTicks(4137), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 1, 17, 37, 33, 559, DateTimeKind.Local).AddTicks(4138) },
                    { new Guid("ffa9f1c1-7207-4588-ab49-63578c3ab209"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 30, 11, 37, 33, 559, DateTimeKind.Local).AddTicks(4126), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 1, 7, 37, 33, 559, DateTimeKind.Local).AddTicks(4127) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorFollowers_MemberId",
                table: "DoctorFollowers",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorFollowers");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b2e95a94-7d09-40e2-86b3-bfd039f914e5"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("46f179b2-34b3-41c6-afcc-eda71423a1dd"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("18f8f760-2ef1-4a5a-af47-733041085420"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ff73a9cb-ed46-46a1-a9d9-451491c42be5"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("747ac2ce-8154-4eac-9fbe-791f3f03bc93"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("57d5e596-42f9-4571-ab20-0b6146d2ea3c"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("aa24c268-d12b-44ab-957a-e60b12904da4"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("8602c5dd-bf2b-42ca-9842-b3294ef39c21"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("7ae03e38-c534-4704-8be1-4309205fa59d"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("b77acc8a-187b-4b19-a03e-e0920b8cea6f"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("2ff78438-0542-4fa0-b3f4-1ba20fc9b53e"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("c5190d8b-f1ea-445e-8a7c-c46b4b5d5a54"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("85bb5ba6-f7c6-4098-8b4b-d53756507777"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("db52b6c9-ffc3-4905-a03d-87f7cc004f02"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ffa9f1c1-7207-4588-ab49-63578c3ab209"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("cf38b56a-fe1d-40fa-b785-57c726b99747"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("4964b6c5-2840-4b75-8471-952b517b233a"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "30452e5a-afd8-4b2d-aa8b-74b9f217f68f");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("a06ed4fd-22dc-4c2e-a5e7-05dfa2588025"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("af33c10b-5449-4edc-a0a9-4088d8e1c7e1"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("2be503e2-3c46-485d-b768-6ee09c106792"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("7fb9d679-9bb5-4f70-ade2-bf600a559a08"), false, "Bsc", null, new DateTime(2023, 9, 30, 5, 29, 6, 375, DateTimeKind.Utc).AddTicks(931), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 30, 11, 29, 6, 375, DateTimeKind.Local).AddTicks(936) },
                    { new Guid("c554b50c-bde1-4318-819f-6e4c366e4aae"), false, "BA", null, new DateTime(2023, 9, 30, 5, 29, 6, 375, DateTimeKind.Utc).AddTicks(958), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 30, 11, 29, 6, 375, DateTimeKind.Local).AddTicks(959) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("18bf68ca-87d3-4eb6-996a-b799aeac2c03"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("a4cd7ef4-e301-447e-a72d-297ea045e7d2") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("ee55e66b-55d1-4b71-98d3-d52ecfb7a794"), false, false, false, new Guid("35c2fcda-2381-48ed-bacc-3b2ed90a8ca8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("f5cb465d-037a-4e5c-a570-712d2acb2fe4"), false, false, false, new Guid("df51947a-e497-43af-bb8e-11d76b459293"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("314e6138-f9fc-4d9f-8644-aadfae83958d"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("eac93320-7bd0-44be-a898-7cfb472f0cbb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("f65e342a-e2d2-4b5d-89b2-72e16d70bf91"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("60a1fbe3-3cdb-4039-ad9c-eb89d56fb6a2") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("740acb6c-f9ff-492c-9823-b13a4dae1f4f"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 30, 11, 29, 6, 375, DateTimeKind.Local).AddTicks(2314), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 1, 17, 29, 6, 375, DateTimeKind.Local).AddTicks(2315) },
                    { new Guid("e25f4acd-c96a-4e82-b6e4-a7bf59e9d9cc"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 30, 11, 29, 6, 375, DateTimeKind.Local).AddTicks(2304), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 1, 7, 29, 6, 375, DateTimeKind.Local).AddTicks(2305) }
                });
        }
    }
}

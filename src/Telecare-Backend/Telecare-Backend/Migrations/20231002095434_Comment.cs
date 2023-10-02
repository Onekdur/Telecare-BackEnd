using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Comment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "DoctorComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorComments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("ea588aba-def0-44f6-8def-9588be508ac2"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("16b509bf-0c76-4ec6-989d-f02bd327c289"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "4c65bdff-071a-48f5-80a2-f4d9313c4080");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("0a2cb079-ede8-40ee-9227-93d430eb117b"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("6b15414a-4d68-473b-939c-d03c70d10b26"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("0da8867d-134f-4adf-b40e-91ce0b7cebcd"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("e7a843b9-9597-4bd9-b531-bb322c633526"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("5d0be66b-5217-44a9-8b95-d66b96d6042a") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("b9335790-b96a-4606-891e-3e879b064f82"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("cfd58afb-364d-4746-89a3-095a7486a75f"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("66a855e7-13cb-4bb9-a9e5-df4a43f1b557"), false, "BA", null, null, new DateTime(2023, 10, 2, 9, 54, 34, 219, DateTimeKind.Utc).AddTicks(9477), null, "Rajshahi University", new DateTime(2028, 10, 2, 15, 54, 34, 219, DateTimeKind.Local).AddTicks(9477), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false },
                    { new Guid("9b0a0959-289f-4ce8-91c3-7e192f203a27"), false, "Bsc", null, null, new DateTime(2023, 10, 2, 9, 54, 34, 219, DateTimeKind.Utc).AddTicks(9446), null, "Islamic University", new DateTime(2028, 10, 2, 15, 54, 34, 219, DateTimeKind.Local).AddTicks(9449), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("660e5039-53e8-4e27-92fd-5f480d15a4fb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("554cf895-b285-4e52-8441-d09a7d80c409") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("3decf149-955f-42e7-ad9a-929255467f5e"), false, false, false, new Guid("a75503a3-2c03-447d-bea9-c497471b8e45"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("ece52685-2df4-4c7e-be9b-d2ceaea0469a"), false, false, false, new Guid("c831d710-8081-414e-9ae2-6ebd33c9f4b8"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("a1a379f0-e63f-4234-8f98-2717fcc92530"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("ef797492-647b-4adf-b5af-3f6badee3ff3"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("0e565c84-945d-44f0-97f9-b0869f9b8146"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("56dc479f-edda-478b-bafc-ecd0757026b7") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5970e7ff-3c5b-4c15-b1ff-177a163ccdf8"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 2, 15, 54, 34, 220, DateTimeKind.Local).AddTicks(348), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 3, 11, 54, 34, 220, DateTimeKind.Local).AddTicks(350), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ed06e92a-2b00-4d42-9009-e3cc9336d3b6"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 2, 15, 54, 34, 220, DateTimeKind.Local).AddTicks(363), false, false, null, " Software Enginer", new DateTime(2023, 10, 3, 21, 54, 34, 220, DateTimeKind.Local).AddTicks(364), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorComments_DoctorId",
                table: "DoctorComments",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorComments");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("ea588aba-def0-44f6-8def-9588be508ac2"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("16b509bf-0c76-4ec6-989d-f02bd327c289"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("0a2cb079-ede8-40ee-9227-93d430eb117b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("6b15414a-4d68-473b-939c-d03c70d10b26"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("e7a843b9-9597-4bd9-b531-bb322c633526"));

            migrationBuilder.DeleteData(
                table: "DoctorPatients",
                keyColumn: "Id",
                keyValue: new Guid("b9335790-b96a-4606-891e-3e879b064f82"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("cfd58afb-364d-4746-89a3-095a7486a75f"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("66a855e7-13cb-4bb9-a9e5-df4a43f1b557"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("9b0a0959-289f-4ce8-91c3-7e192f203a27"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("660e5039-53e8-4e27-92fd-5f480d15a4fb"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("3decf149-955f-42e7-ad9a-929255467f5e"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("ece52685-2df4-4c7e-be9b-d2ceaea0469a"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("a1a379f0-e63f-4234-8f98-2717fcc92530"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("ef797492-647b-4adf-b5af-3f6badee3ff3"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("0e565c84-945d-44f0-97f9-b0869f9b8146"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("5970e7ff-3c5b-4c15-b1ff-177a163ccdf8"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("ed06e92a-2b00-4d42-9009-e3cc9336d3b6"));

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
    }
}

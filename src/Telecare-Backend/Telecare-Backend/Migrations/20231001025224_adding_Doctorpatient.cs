using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class adding_Doctorpatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("d9d70b28-7e59-4f0c-917e-a162d9d2d0a4"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("fe823efa-8132-4681-a7cd-c5531695b250"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("55f0d3be-cb69-4e0f-84cd-069365367da2"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("56dd8c2b-e64d-43ff-8478-1ab99451a292"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("53660fce-f5f5-4113-bd4e-f61403f389ae"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("37a28cfe-64c1-4b3f-9a74-278a6f601add"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("6c06c3f4-aef4-479c-985d-6d309e5f7d59"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("c881ab90-d584-4422-a188-be71554c2800"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("46c3eaea-2702-4c96-9a3f-ba6588286b67"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("5f214b22-c1c9-4916-9170-b200b6a75c67"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("13726f45-2689-4cfc-943e-eca9ec1d6450"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("392044cd-3405-4347-b1fd-92ffcf7df99c"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("8aaa3b96-6e25-4905-aa8d-b782b0cee99a"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("886546b6-4c18-4be6-b547-665a931d94ba"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("89b0d818-4c6f-4c6c-962d-79e293cdff0d"));

            migrationBuilder.CreateTable(
                name: "DoctorPatients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_DoctorId",
                table: "DoctorPatients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId",
                unique: true,
                filter: "[PatientId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorPatients");

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
                values: new object[] { new Guid("d9d70b28-7e59-4f0c-917e-a162d9d2d0a4"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("fe823efa-8132-4681-a7cd-c5531695b250"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "f53c9167-b69a-4dde-8f33-5e9daaa222a6");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("55f0d3be-cb69-4e0f-84cd-069365367da2"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("56dd8c2b-e64d-43ff-8478-1ab99451a292"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("53660fce-f5f5-4113-bd4e-f61403f389ae"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("71916fca-82fe-4913-9696-0457f6bef433") });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("37a28cfe-64c1-4b3f-9a74-278a6f601add"), false, "BA", null, new DateTime(2023, 9, 30, 7, 40, 41, 177, DateTimeKind.Utc).AddTicks(2099), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(2099) },
                    { new Guid("6c06c3f4-aef4-479c-985d-6d309e5f7d59"), false, "Bsc", null, new DateTime(2023, 9, 30, 7, 40, 41, 177, DateTimeKind.Utc).AddTicks(2057), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(2067) }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("c881ab90-d584-4422-a188-be71554c2800"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("675be60b-7338-4a11-bb48-12c119871ff8") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("46c3eaea-2702-4c96-9a3f-ba6588286b67"), false, false, false, new Guid("e946af80-3944-46cf-aa02-656d9fc83fd9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("5f214b22-c1c9-4916-9170-b200b6a75c67"), false, false, false, new Guid("7f37a5d9-9639-4f53-aab0-ef04600e6456"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("13726f45-2689-4cfc-943e-eca9ec1d6450"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("392044cd-3405-4347-b1fd-92ffcf7df99c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("8aaa3b96-6e25-4905-aa8d-b782b0cee99a"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("ca05c257-4933-43f0-9441-60df8e70dea3") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("886546b6-4c18-4be6-b547-665a931d94ba"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(4087), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 10, 1, 9, 40, 41, 177, DateTimeKind.Local).AddTicks(4090) },
                    { new Guid("89b0d818-4c6f-4c6c-962d-79e293cdff0d"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(4152), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 10, 1, 19, 40, 41, 177, DateTimeKind.Local).AddTicks(4153) }
                });
        }
    }
}

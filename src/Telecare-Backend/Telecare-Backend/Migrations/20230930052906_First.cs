using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GenDer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeactivate = table.Column<bool>(type: "bit", nullable: false),
                    RelationShipStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParmanentAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CEO = table.Column<bool>(type: "bit", nullable: false),
                    SuperAdmin = table.Column<bool>(type: "bit", nullable: false),
                    GeneralAdmin = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoverPhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoverPhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ispresent = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoverPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoverPhotos_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HscCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSCCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalSchoolCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalIdCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accept = table.Column<bool>(type: "bit", nullable: false),
                    Pending = table.Column<bool>(type: "bit", nullable: false),
                    Reject = table.Column<bool>(type: "bit", nullable: false),
                    isSeen = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorRequests_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CureentlyRunnig = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FriendRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FriendRequests_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FriendId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Block = table.Column<bool>(type: "bit", nullable: false),
                    MessageBlock = table.Column<bool>(type: "bit", nullable: false),
                    BlockFromMe = table.Column<bool>(type: "bit", nullable: false),
                    BlockFromFriend = table.Column<bool>(type: "bit", nullable: false),
                    MessageBlockFromME = table.Column<bool>(type: "bit", nullable: false),
                    MessageBlockFromFriend = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friends_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfilePhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    profilePhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfilePhotos_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SendingRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SendFriendRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendingRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendingRequests_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComapnyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentlyRunning = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GenDer", "IsDeactivate", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RelationShipStatus", "UserName" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "30452e5a-afd8-4b2d-aa8b-74b9f217f68f", "mdsojibhosen444@gmail.com", true, "Md Sojib", "Male", false, "Khan", null, null, "dhsgdwe323", "01778553706", false, "Single", null });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("cf38b56a-fe1d-40fa-b785-57c726b99747"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("4964b6c5-2840-4b75-8471-952b517b233a"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MemberId",
                table: "Addresses",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_MemberId",
                table: "Admins",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CoverPhotos_MemberId",
                table: "CoverPhotos",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorRequests_MemberId",
                table: "DoctorRequests",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_MemberId",
                table: "Educations",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequests_MemberId",
                table: "FriendRequests",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_MemberId",
                table: "Friends",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePhotos_MemberId",
                table: "ProfilePhotos",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SendingRequests_MemberId",
                table: "SendingRequests",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_MemberId",
                table: "Works",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CoverPhotos");

            migrationBuilder.DropTable(
                name: "DoctorRequests");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "FriendRequests");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "ProfilePhotos");

            migrationBuilder.DropTable(
                name: "SendingRequests");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

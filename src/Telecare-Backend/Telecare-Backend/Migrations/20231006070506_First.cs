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
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    IsDeactivate = table.Column<bool>(type: "bit", nullable: false),
                    IsBlock = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
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
                    AdminType = table.Column<int>(type: "int", nullable: false),
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
                name: "DoctorComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorComments_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorComments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorFollowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorFollowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorFollowers_AspNetUsers_FollowerId",
                        column: x => x.FollowerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorFollowers_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorProfiles",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorProfiles", x => new { x.MemberId, x.DoctorID });
                    table.ForeignKey(
                        name: "FK_DoctorProfiles_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorProfiles_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
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
                    isPrivate = table.Column<bool>(type: "bit", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Educations_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PatientComplains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientComplains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientComplains_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientComplains_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
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
                    IsPrivate = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_AspNetUsers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Works_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "GenDer", "IsDeactivate", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RelationShipStatus", "UserName" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "b6f864be-fdbe-43e5-bfe4-0db5899bc677", "mdsojibhosen444@gmail.com", true, "Md Sojib", "Male", false, "Khan", null, null, "dhsgdwe323", "01778553706", false, "Single", null });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Description", "Experties", "FullName", "IsBlock", "IsDeactivate", "PhotoLink", "Rating", "isActive" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), "I am pathologist", "Surgery", "Dr Md Sagore", false, false, "www.aws.com", 4.5999999999999996, false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("6722965b-16e7-4c57-828d-e354171ec214"), false, "Bsc", null, null, new DateTime(2023, 10, 6, 7, 5, 6, 79, DateTimeKind.Utc).AddTicks(4602), null, "Islamic University", new DateTime(2028, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(4606), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("6d8035f7-f870-4614-8235-c79e9497ba74"), false, "BA", null, null, new DateTime(2023, 10, 6, 7, 5, 6, 79, DateTimeKind.Utc).AddTicks(4629), null, "Rajshahi University", new DateTime(2028, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(4630), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Text", "Time", "UserId", "UserType" },
                values: new object[,]
                {
                    { new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82"), "Good morning friens", new DateTime(2023, 10, 6, 13, 5, 6, 81, DateTimeKind.Local).AddTicks(8957), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), 0 },
                    { new Guid("f53c694b-050c-42a3-8b18-7d389ed240ae"), "Good morning friens", new DateTime(2023, 10, 6, 13, 5, 6, 81, DateTimeKind.Local).AddTicks(8969), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ba02c76-2044-42d2-88e6-615109dc5d7e"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(5641), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 7, 9, 5, 6, 79, DateTimeKind.Local).AddTicks(5642), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("d00c531f-5958-4e78-a088-8db0557ae230"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 6, 13, 5, 6, 79, DateTimeKind.Local).AddTicks(5651), false, false, null, " Software Enginer", new DateTime(2023, 10, 7, 19, 5, 6, 79, DateTimeKind.Local).AddTicks(5652), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("b5037567-857e-425c-acda-1ed1453df7fe"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("5416ed65-f768-4d15-b87c-821afa5c368e"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("12055a35-3d61-4212-b96a-cf7dfe56018b"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("6a1ff212-6c24-4a12-bfa8-ecc4ae057995"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId", "Time" },
                values: new object[] { new Guid("e17a34fb-d50f-40a9-b059-28695feab85f"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new DateTime(2023, 10, 6, 7, 5, 6, 81, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("90cbc9a7-91fa-41ec-a199-0b1a4b6b1fea"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "DoctorId", "PatientId" },
                values: new object[] { new Guid("f5d0bff6-67a1-4167-97e2-0921ccc52239"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorProfiles",
                columns: new[] { "DoctorID", "MemberId" },
                values: new object[] { new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("1e4ec300-8d14-4707-93ea-5092ae7d10ee"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("7f2f7d64-754c-4cd7-a39b-9c0470bb1e28"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("b7a2a3f0-2a08-433c-94ae-e5d8cf36449a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("2dd37c87-8ff5-4b1b-a310-1d7f7d174999"), false, false, false, new Guid("5cffdbc0-7748-4e5f-9655-52263659a9a1"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("c3940e7d-3c5a-456d-8f71-10e16a259206"), false, false, false, new Guid("92a91119-434f-454e-95de-ccbc2077fa89"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("691fec75-47c7-405b-b9f0-81b3dca3ec67"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "PhotLink", "PostId" },
                values: new object[] { new Guid("63eb860b-2fde-4b64-8870-aa795ad26ae8"), "www.aws.com", new Guid("0e1c1417-8dc0-4e9e-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("05a0088a-8f0e-4dc2-a0d9-4ba8abd6b281"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("43fe52bd-caf3-4662-8f93-67f1da3113b8"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("326f3e96-6d39-47e9-b80e-2e3eafdfd364"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("e3c296c9-8d3e-467f-be9e-93f6bd7829bb") });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_MemberId",
                table: "Addresses",
                column: "MemberId");

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
                name: "IX_DoctorComments_DoctorId",
                table: "DoctorComments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorComments_PatientId",
                table: "DoctorComments",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorFollowers_DoctorId",
                table: "DoctorFollowers",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorFollowers_FollowerId",
                table: "DoctorFollowers",
                column: "FollowerId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_DoctorId",
                table: "DoctorPatients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatients",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorProfiles_DoctorID",
                table: "DoctorProfiles",
                column: "DoctorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorProfiles_MemberId",
                table: "DoctorProfiles",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorRequests_MemberId",
                table: "DoctorRequests",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_DoctorId",
                table: "Educations",
                column: "DoctorId");

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
                name: "IX_PatientComplains_DoctorId",
                table: "PatientComplains",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientComplains_PatientId",
                table: "PatientComplains",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PostId",
                table: "Photos",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfilePhotos_MemberId",
                table: "ProfilePhotos",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SendingRequests_MemberId",
                table: "SendingRequests",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_DoctorId",
                table: "Works",
                column: "DoctorId");

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
                name: "DoctorComments");

            migrationBuilder.DropTable(
                name: "DoctorFollowers");

            migrationBuilder.DropTable(
                name: "DoctorPatients");

            migrationBuilder.DropTable(
                name: "DoctorProfiles");

            migrationBuilder.DropTable(
                name: "DoctorRequests");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "FriendRequests");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "PatientComplains");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "ProfilePhotos");

            migrationBuilder.DropTable(
                name: "SendingRequests");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}

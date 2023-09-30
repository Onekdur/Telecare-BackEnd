﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Telecare.Persistance.Contexts;

#nullable disable

namespace Telecare_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Friends.Friend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Block")
                        .HasColumnType("bit");

                    b.Property<bool>("BlockFromFriend")
                        .HasColumnType("bit");

                    b.Property<bool>("BlockFromMe")
                        .HasColumnType("bit");

                    b.Property<Guid>("FriendId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("MessageBlock")
                        .HasColumnType("bit");

                    b.Property<bool>("MessageBlockFromFriend")
                        .HasColumnType("bit");

                    b.Property<bool>("MessageBlockFromME")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5f214b22-c1c9-4916-9170-b200b6a75c67"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendId = new Guid("7f37a5d9-9639-4f53-aab0-ef04600e6456"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            MessageBlock = false,
                            MessageBlockFromFriend = false,
                            MessageBlockFromME = false
                        },
                        new
                        {
                            Id = new Guid("46c3eaea-2702-4c96-9a3f-ba6588286b67"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendId = new Guid("e946af80-3944-46cf-aa02-656d9fc83fd9"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            MessageBlock = false,
                            MessageBlockFromFriend = false,
                            MessageBlockFromME = false
                        });
                });

            modelBuilder.Entity("Entities.Models.Friends.FriendRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsSeen")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("FriendRequests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c881ab90-d584-4422-a188-be71554c2800"),
                            IsSeen = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            RequestId = new Guid("675be60b-7338-4a11-bb48-12c119871ff8")
                        });
                });

            modelBuilder.Entity("Entities.Models.Friends.SendingRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SendFriendRequestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("SendingRequests");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8aaa3b96-6e25-4905-aa8d-b782b0cee99a"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SendFriendRequestId = new Guid("ca05c257-4933-43f0-9441-60df8e70dea3")
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParmanentAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9d70b28-7e59-4f0c-917e-a162d9d2d0a4"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            ParmanentAdress = "Pabna",
                            PresentAddress = "Kushtia"
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.CoverPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CoverPhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ispresent")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("CoverPhotos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("55f0d3be-cb69-4e0f-84cd-069365367da2"),
                            CoverPhotoLink = "www.colud.com",
                            Ispresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
                        },
                        new
                        {
                            Id = new Guid("56dd8c2b-e64d-43ff-8478-1ab99451a292"),
                            CoverPhotoLink = "www.aws.com",
                            Ispresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CureentlyRunnig")
                        .HasColumnType("bit");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c06c3f4-aef4-479c-985d-6d309e5f7d59"),
                            CureentlyRunnig = false,
                            Degree = "Bsc",
                            From = new DateTime(2023, 9, 30, 7, 40, 41, 177, DateTimeKind.Utc).AddTicks(2057),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Islamic University",
                            To = new DateTime(2028, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(2067)
                        },
                        new
                        {
                            Id = new Guid("37a28cfe-64c1-4b3f-9a74-278a6f601add"),
                            CureentlyRunnig = false,
                            Degree = "BA",
                            From = new DateTime(2023, 9, 30, 7, 40, 41, 177, DateTimeKind.Utc).AddTicks(2099),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Rajshahi University",
                            To = new DateTime(2028, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(2099)
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GenDer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeactivate")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RelationShipStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            ConcurrencyStamp = "f53c9167-b69a-4dde-8f33-5e9daaa222a6",
                            Email = "mdsojibhosen444@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Md Sojib",
                            GenDer = "Male",
                            IsDeactivate = false,
                            LastName = "Khan",
                            PasswordHash = "dhsgdwe323",
                            PhoneNumber = "01778553706",
                            PhoneNumberConfirmed = false,
                            RelationShipStatus = "Single"
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.ProfilePhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("profilePhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("ProfilePhotos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("13726f45-2689-4cfc-943e-eca9ec1d6450"),
                            IsPresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            profilePhotoLink = "www.colud.com"
                        },
                        new
                        {
                            Id = new Guid("392044cd-3405-4347-b1fd-92ffcf7df99c"),
                            IsPresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            profilePhotoLink = "www.aws.com"
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Work", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ComapnyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CurrentlyRunning")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Works");

                    b.HasData(
                        new
                        {
                            Id = new Guid("886546b6-4c18-4be6-b547-665a931d94ba"),
                            ComapnyName = "Devskill",
                            CurrentlyRunning = false,
                            Description = "Hi this sojib",
                            From = new DateTime(2023, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(4087),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = "Intern Software Enginer",
                            To = new DateTime(2023, 10, 1, 9, 40, 41, 177, DateTimeKind.Local).AddTicks(4090)
                        },
                        new
                        {
                            Id = new Guid("89b0d818-4c6f-4c6c-962d-79e293cdff0d"),
                            ComapnyName = "Vivasoft",
                            CurrentlyRunning = false,
                            Description = "Descriptiom",
                            From = new DateTime(2023, 9, 30, 13, 40, 41, 177, DateTimeKind.Local).AddTicks(4152),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = " Software Enginer",
                            To = new DateTime(2023, 10, 1, 19, 40, 41, 177, DateTimeKind.Local).AddTicks(4153)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Telecare.Domain.Entities.Admins.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CEO")
                        .HasColumnType("bit");

                    b.Property<bool>("GeneralAdmin")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("SuperAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe823efa-8132-4681-a7cd-c5531695b250"),
                            CEO = false,
                            GeneralAdmin = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SuperAdmin = false
                        });
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBlock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeactivate")
                        .HasColumnType("bit");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhotoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"),
                            Description = "I am pathologist",
                            Experties = "Surgery",
                            FullName = "Dr Md Sagore",
                            IsBlock = false,
                            IsDeactivate = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            PhotoLink = "www.aws.com",
                            Rating = 4.5999999999999996,
                            isActive = false
                        });
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorFollower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FollowerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorFollowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53660fce-f5f5-4113-bd4e-f61403f389ae"),
                            DoctorId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"),
                            FollowerId = new Guid("71916fca-82fe-4913-9696-0457f6bef433")
                        });
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Accept")
                        .HasColumnType("bit");

                    b.Property<string>("Experties")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HscCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalIdCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalSchoolCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Pending")
                        .HasColumnType("bit");

                    b.Property<bool>("Reject")
                        .HasColumnType("bit");

                    b.Property<string>("SSCCertificate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSeen")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("DoctorRequest");
                });

            modelBuilder.Entity("Entities.Models.Friends.Friend", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("Friends")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Friends.FriendRequest", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("FriendRequests")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Friends.SendingRequest", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("SendingRequests")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.Address", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithOne("Addresses")
                        .HasForeignKey("Entities.Models.Members.Address", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.CoverPhoto", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("CoverPicture")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.Education", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("Educations")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.ProfilePhoto", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("ProfilePicture")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.Work", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("Works")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Telecare.Domain.Entities.Admins.Admin", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithOne("Admins")
                        .HasForeignKey("Telecare.Domain.Entities.Admins.Admin", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.Doctor", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithOne("Doctor")
                        .HasForeignKey("Telecare.Domain.Entities.User.Doctor.Doctor", "MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorFollower", b =>
                {
                    b.HasOne("Telecare.Domain.Entities.User.Doctor.Doctor", "Doctor")
                        .WithMany("DoctorFollowers")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorRequest", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("DoctorRequests")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entities.Models.Members.Member", b =>
                {
                    b.Navigation("Addresses")
                        .IsRequired();

                    b.Navigation("Admins")
                        .IsRequired();

                    b.Navigation("CoverPicture");

                    b.Navigation("Doctor")
                        .IsRequired();

                    b.Navigation("DoctorRequests");

                    b.Navigation("Educations");

                    b.Navigation("FriendRequests");

                    b.Navigation("Friends");

                    b.Navigation("ProfilePicture");

                    b.Navigation("SendingRequests");

                    b.Navigation("Works");
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.Doctor", b =>
                {
                    b.Navigation("DoctorFollowers");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Telecare.Persistance.Contexts;

#nullable disable

namespace Telecare_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231001030003_adding_Doctorpatient_2")]
    partial class adding_Doctorpatient_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("2fe6e77d-50bd-47e6-8e54-fbc5a9f069a8"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendId = new Guid("9e59833a-af34-4ad4-aba9-6f22005002c5"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            MessageBlock = false,
                            MessageBlockFromFriend = false,
                            MessageBlockFromME = false
                        },
                        new
                        {
                            Id = new Guid("a8b9547a-de73-47cc-9738-694a5964eb09"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendId = new Guid("86dc471b-0a41-440e-af63-8a2d4212231f"),
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
                            Id = new Guid("5358b5d2-cc9a-4cbb-9beb-4f03aec349a5"),
                            IsSeen = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            RequestId = new Guid("757b4908-4e8f-4b2e-b662-a6bee90f2687")
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
                            Id = new Guid("a88f0822-ec65-45df-bb2c-1aac1b67cc3d"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SendFriendRequestId = new Guid("bcf2955b-7393-4e70-ae16-a2e95a94934e")
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
                            Id = new Guid("2311db32-e119-4df4-99bd-bcfe5dfe7f8e"),
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
                            Id = new Guid("0fbb4405-6f66-42d7-8090-2e4f783708ec"),
                            CoverPhotoLink = "www.colud.com",
                            Ispresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
                        },
                        new
                        {
                            Id = new Guid("0a2f5d0c-27b1-4864-93ee-9ef85de95e08"),
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
                            Id = new Guid("194dce1c-0796-4ec2-9f65-9423030ac81a"),
                            CureentlyRunnig = false,
                            Degree = "Bsc",
                            From = new DateTime(2023, 10, 1, 3, 0, 2, 822, DateTimeKind.Utc).AddTicks(8275),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Islamic University",
                            To = new DateTime(2028, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(8278)
                        },
                        new
                        {
                            Id = new Guid("fba0c4f0-fd6d-4378-a662-1cc3783a2086"),
                            CureentlyRunnig = false,
                            Degree = "BA",
                            From = new DateTime(2023, 10, 1, 3, 0, 2, 822, DateTimeKind.Utc).AddTicks(8300),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Rajshahi University",
                            To = new DateTime(2028, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(8301)
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
                            ConcurrencyStamp = "fa73247c-577a-4295-8e5b-1d39c5599061",
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
                            Id = new Guid("2e2d8a5a-7f8a-4a0d-a79f-91edc6f6dbf2"),
                            IsPresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            profilePhotoLink = "www.colud.com"
                        },
                        new
                        {
                            Id = new Guid("2f350f83-3d04-4280-b6bf-cae1468b993d"),
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
                            Id = new Guid("9b979430-516d-4e56-b457-caf35551e550"),
                            ComapnyName = "Devskill",
                            CurrentlyRunning = false,
                            Description = "Hi this sojib",
                            From = new DateTime(2023, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(9253),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = "Intern Software Enginer",
                            To = new DateTime(2023, 10, 2, 5, 0, 2, 822, DateTimeKind.Local).AddTicks(9255)
                        },
                        new
                        {
                            Id = new Guid("c91b34bd-b3e0-4dfd-8e66-64ea4dbb209e"),
                            ComapnyName = "Vivasoft",
                            CurrentlyRunning = false,
                            Description = "Descriptiom",
                            From = new DateTime(2023, 10, 1, 9, 0, 2, 822, DateTimeKind.Local).AddTicks(9264),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = " Software Enginer",
                            To = new DateTime(2023, 10, 2, 15, 0, 2, 822, DateTimeKind.Local).AddTicks(9265)
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
                            Id = new Guid("e14b8391-40ea-485a-917e-8878627671cb"),
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
                            Id = new Guid("2d35c6db-cba0-4fe8-a5f2-088fe0d337f5"),
                            DoctorId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"),
                            FollowerId = new Guid("ca82d6c2-5514-4ddf-915c-4f320ef5096c")
                        });
                });

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorPatient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DoctorId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId")
                        .IsUnique()
                        .HasFilter("[PatientId] IS NOT NULL");

                    b.ToTable("DoctorPatients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d472dfe8-7ad1-4c5b-8f59-87a5f3404f83"),
                            DoctorId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"),
                            PatientId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
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

            modelBuilder.Entity("Telecare.Domain.Entities.User.Doctor.DoctorPatient", b =>
                {
                    b.HasOne("Telecare.Domain.Entities.User.Doctor.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithOne("DoctorPatient")
                        .HasForeignKey("Telecare.Domain.Entities.User.Doctor.DoctorPatient", "PatientId");

                    b.Navigation("Doctor");

                    b.Navigation("Member");
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

                    b.Navigation("DoctorPatient")
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
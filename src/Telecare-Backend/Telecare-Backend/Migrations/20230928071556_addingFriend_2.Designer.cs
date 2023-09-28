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
    [Migration("20230928071556_addingFriend_2")]
    partial class addingFriend_2
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
                    b.Property<Guid>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Block")
                        .HasColumnType("bit");

                    b.Property<bool>("BlockFromFriend")
                        .HasColumnType("bit");

                    b.Property<bool>("BlockFromMe")
                        .HasColumnType("bit");

                    b.Property<Guid>("FriendUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("MessageBlock")
                        .HasColumnType("bit");

                    b.Property<bool>("MessageBlockFromFriend")
                        .HasColumnType("bit");

                    b.Property<bool>("MessageBlockFromME")
                        .HasColumnType("bit");

                    b.HasKey("FriendId");

                    b.HasIndex("MemberId");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            FriendId = new Guid("7d741dbb-b8e9-4319-a75f-9871f54c254a"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendUserId = new Guid("f8c26f33-64f3-44d4-97ae-9d04a1f33f25"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            MessageBlock = false,
                            MessageBlockFromFriend = false,
                            MessageBlockFromME = false
                        },
                        new
                        {
                            FriendId = new Guid("988102f3-f78a-4231-aa68-f63d4fd273b0"),
                            Block = false,
                            BlockFromFriend = false,
                            BlockFromMe = false,
                            FriendUserId = new Guid("188d4bbf-2b26-451f-acbc-00b244d0ddd9"),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            MessageBlock = false,
                            MessageBlockFromFriend = false,
                            MessageBlockFromME = false
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Address", b =>
                {
                    b.Property<Guid>("AddressID")
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

                    b.HasKey("AddressID");

                    b.HasIndex("MemberId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressID = new Guid("3bdd6706-98e4-4459-8516-2699d2ca3fe2"),
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
                            Id = new Guid("da8fde5c-bc35-4844-9656-d7bf04a62bae"),
                            CoverPhotoLink = "www.colud.com",
                            Ispresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
                        },
                        new
                        {
                            Id = new Guid("8ec0f560-dbf3-4acd-9fa1-3f18942952d0"),
                            CoverPhotoLink = "www.aws.com",
                            Ispresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82")
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Education", b =>
                {
                    b.Property<Guid>("EnducationId")
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

                    b.HasKey("EnducationId");

                    b.HasIndex("MemberId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            EnducationId = new Guid("f69ae2ed-4552-4b98-aa10-fb7c3e25a823"),
                            CureentlyRunnig = false,
                            Degree = "Bsc",
                            From = new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8466),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Islamic University",
                            To = new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8470)
                        },
                        new
                        {
                            EnducationId = new Guid("7870e399-240d-4f30-999f-56eead9a63d6"),
                            CureentlyRunnig = false,
                            Degree = "BA",
                            From = new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8493),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            SchoolName = "Rajshahi University",
                            To = new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8494)
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
                            ConcurrencyStamp = "94e2bede-60c0-4652-bca4-a254c63033c2",
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
                            Id = new Guid("7d48d4f1-09af-4429-b1ef-481f69d7fc79"),
                            IsPresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            profilePhotoLink = "www.colud.com"
                        },
                        new
                        {
                            Id = new Guid("78fe3ce9-e185-4973-aa8b-138c0bcbe3ce"),
                            IsPresent = false,
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            profilePhotoLink = "www.aws.com"
                        });
                });

            modelBuilder.Entity("Entities.Models.Members.Work", b =>
                {
                    b.Property<Guid>("WorkId")
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

                    b.HasKey("WorkId");

                    b.HasIndex("MemberId");

                    b.ToTable("Works");

                    b.HasData(
                        new
                        {
                            WorkId = new Guid("43a95f53-bf07-45af-bd6c-65786188d72b"),
                            ComapnyName = "Devskill",
                            CurrentlyRunning = false,
                            Description = "Hi this sojib",
                            From = new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9313),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = "Intern Software Enginer",
                            To = new DateTime(2023, 9, 29, 9, 15, 56, 182, DateTimeKind.Local).AddTicks(9314)
                        },
                        new
                        {
                            WorkId = new Guid("cb981417-5f24-4561-bb36-eacf8a239a52"),
                            ComapnyName = "Vivasoft",
                            CurrentlyRunning = false,
                            Description = "Descriptiom",
                            From = new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9328),
                            MemberId = new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                            Title = " Software Enginer",
                            To = new DateTime(2023, 9, 29, 19, 15, 56, 182, DateTimeKind.Local).AddTicks(9329)
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

            modelBuilder.Entity("Entities.Models.Friends.Friend", b =>
                {
                    b.HasOne("Entities.Models.Members.Member", "Member")
                        .WithMany("Friends")
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

            modelBuilder.Entity("Entities.Models.Members.Member", b =>
                {
                    b.Navigation("Addresses")
                        .IsRequired();

                    b.Navigation("CoverPicture");

                    b.Navigation("Educations");

                    b.Navigation("Friends");

                    b.Navigation("ProfilePicture");

                    b.Navigation("Works");
                });
#pragma warning restore 612, 618
        }
    }
}

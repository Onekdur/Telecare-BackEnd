using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class addingFriend_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("7786865e-0c25-4625-88bf-672d52a83343"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("3a0dfaf6-f59e-4472-a02d-6221100a536b"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("7ca17516-956e-4ba6-aa25-bf0f1e5e2a56"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("b317de3f-8af0-424a-9657-7f2fb78b4a62"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("d5c62e9f-bf5b-4e32-8ebc-4f44698e3a3f"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("1784b75e-7e79-43a1-ae62-db1eb87881ca"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("50dbdf3b-aacc-4a83-93c1-137519337c33"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("562e3a39-0604-43c7-aa9e-8524d06464cb"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("86641faa-c0ae-421d-8999-fcfb4ad0fce0"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("2815cef2-6b3e-4fde-84ea-ef18535662eb"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("c3f8d575-7e6f-4883-931e-3321d2a314b1"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("3bdd6706-98e4-4459-8516-2699d2ca3fe2"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "94e2bede-60c0-4652-bca4-a254c63033c2");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("8ec0f560-dbf3-4acd-9fa1-3f18942952d0"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("da8fde5c-bc35-4844-9656-d7bf04a62bae"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("7870e399-240d-4f30-999f-56eead9a63d6"), false, "BA", null, new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8493), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8494) },
                    { new Guid("f69ae2ed-4552-4b98-aa10-fb7c3e25a823"), false, "Bsc", null, new DateTime(2023, 9, 28, 7, 15, 56, 182, DateTimeKind.Utc).AddTicks(8466), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(8470) }
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("7d741dbb-b8e9-4319-a75f-9871f54c254a"), false, false, false, new Guid("f8c26f33-64f3-44d4-97ae-9d04a1f33f25"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("988102f3-f78a-4231-aa68-f63d4fd273b0"), false, false, false, new Guid("188d4bbf-2b26-451f-acbc-00b244d0ddd9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("78fe3ce9-e185-4973-aa8b-138c0bcbe3ce"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("7d48d4f1-09af-4429-b1ef-481f69d7fc79"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("43a95f53-bf07-45af-bd6c-65786188d72b"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9313), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 9, 15, 56, 182, DateTimeKind.Local).AddTicks(9314) },
                    { new Guid("cb981417-5f24-4561-bb36-eacf8a239a52"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 13, 15, 56, 182, DateTimeKind.Local).AddTicks(9328), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 19, 15, 56, 182, DateTimeKind.Local).AddTicks(9329) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("3bdd6706-98e4-4459-8516-2699d2ca3fe2"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("8ec0f560-dbf3-4acd-9fa1-3f18942952d0"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("da8fde5c-bc35-4844-9656-d7bf04a62bae"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("7870e399-240d-4f30-999f-56eead9a63d6"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "EnducationId",
                keyValue: new Guid("f69ae2ed-4552-4b98-aa10-fb7c3e25a823"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("7d741dbb-b8e9-4319-a75f-9871f54c254a"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "FriendId",
                keyValue: new Guid("988102f3-f78a-4231-aa68-f63d4fd273b0"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("78fe3ce9-e185-4973-aa8b-138c0bcbe3ce"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("7d48d4f1-09af-4429-b1ef-481f69d7fc79"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("43a95f53-bf07-45af-bd6c-65786188d72b"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "WorkId",
                keyValue: new Guid("cb981417-5f24-4561-bb36-eacf8a239a52"));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("7786865e-0c25-4625-88bf-672d52a83343"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "79a96460-217b-4c33-bc32-4a7db3fba177");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("3a0dfaf6-f59e-4472-a02d-6221100a536b"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("7ca17516-956e-4ba6-aa25-bf0f1e5e2a56"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "EnducationId", "CureentlyRunnig", "Degree", "Description", "From", "MemberId", "SchoolName", "To" },
                values: new object[,]
                {
                    { new Guid("b317de3f-8af0-424a-9657-7f2fb78b4a62"), false, "BA", null, new DateTime(2023, 9, 28, 7, 9, 17, 113, DateTimeKind.Utc).AddTicks(7546), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Rajshahi University", new DateTime(2028, 9, 28, 13, 9, 17, 113, DateTimeKind.Local).AddTicks(7547) },
                    { new Guid("d5c62e9f-bf5b-4e32-8ebc-4f44698e3a3f"), false, "Bsc", null, new DateTime(2023, 9, 28, 7, 9, 17, 113, DateTimeKind.Utc).AddTicks(7521), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Islamic University", new DateTime(2028, 9, 28, 13, 9, 17, 113, DateTimeKind.Local).AddTicks(7526) }
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "FriendId", "Block", "BlockFromFriend", "BlockFromMe", "FriendUserId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("1784b75e-7e79-43a1-ae62-db1eb87881ca"), false, false, false, new Guid("f5721880-2cfa-4f3c-b3cf-004418c668d9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("50dbdf3b-aacc-4a83-93c1-137519337c33"), false, false, false, new Guid("75dc8da2-4093-49ec-85bf-5c4c507eb68f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("562e3a39-0604-43c7-aa9e-8524d06464cb"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("86641faa-c0ae-421d-8999-fcfb4ad0fce0"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "WorkId", "ComapnyName", "CurrentlyRunning", "Description", "From", "MemberId", "Title", "To" },
                values: new object[,]
                {
                    { new Guid("2815cef2-6b3e-4fde-84ea-ef18535662eb"), "Vivasoft", false, "Descriptiom", new DateTime(2023, 9, 28, 13, 9, 17, 113, DateTimeKind.Local).AddTicks(9425), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), " Software Enginer", new DateTime(2023, 9, 29, 19, 9, 17, 113, DateTimeKind.Local).AddTicks(9426) },
                    { new Guid("c3f8d575-7e6f-4883-931e-3321d2a314b1"), "Devskill", false, "Hi this sojib", new DateTime(2023, 9, 28, 13, 9, 17, 113, DateTimeKind.Local).AddTicks(9414), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Intern Software Enginer", new DateTime(2023, 9, 29, 9, 9, 17, 113, DateTimeKind.Local).AddTicks(9416) }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Telecare_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Admin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Admins_MemberId",
                table: "Admins");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b6f8204f-a5a4-48fb-86d7-33729aab045f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("d0771ae1-7b9e-446b-ac77-a6380440be63"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("be5e9a29-1cb5-4c85-b195-4a9187fb5f80"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("ccc2494f-6238-4dda-b460-1ed31b00f6e2"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("d23e9bb1-0648-494a-82f6-5973be064707"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("44f1c367-69cd-4aef-a11f-8cf291bc12f7"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("dec65ab6-8c99-4069-81c7-57c8aa83bc99"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("11bc8b7d-2b97-4066-8f65-40f06bf476db"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("f72eacbf-0345-4dcb-b11a-991f9990bad7"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("576d20bf-d13b-4dc5-94fc-a24bae36005c"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("6fe11252-1fd1-4a94-845f-d118e83345cf"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("74316cad-9e2e-45ce-bfa7-6f60aa77be59"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("12fee9be-1198-45af-acf8-c7a3eff84a44"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("806f066f-efaf-410a-afd9-82258a4eca02"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f2f46e56-e700-4f35-992c-facc4d247380"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("11e3107c-484c-4818-a1dd-5da60c29e5be"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("051edc91-51cc-4fd9-8dd9-3b0727d19e4f"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("14e4936e-6804-472b-b4e2-b87167d52788"));

            migrationBuilder.DropColumn(
                name: "CEO",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "GeneralAdmin",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "SuperAdmin",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "AdminType",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("74f6c753-8e44-4e4e-89e6-f60eac62760f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminType", "MemberId" },
                values: new object[] { new Guid("715018cd-13d4-4b55-9df3-4d816307a1af"), 0, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "a4c2084d-8072-47f4-9cda-742db7fef9b1");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("67cd293f-a5ca-40c9-81c4-82328aadac25"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("b339b7f4-0c36-4509-8abc-2bc7b5d18b13"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("3ff39c55-fbdc-4e41-afe1-1c9ad38b58ed"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("ba2fa72a-4c6f-4c7f-9c7c-807688c766ae"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("a5dd227d-d5fd-497c-86db-de8ec40a6fa6") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("ba377e80-1e1c-4e1b-9cbf-51c146520511"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("5079c7e5-a95e-4922-8adf-3577df24765d"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 6, 55, 51, 867, DateTimeKind.Utc).AddTicks(9342), null, "Islamic University", new DateTime(2028, 10, 3, 12, 55, 51, 867, DateTimeKind.Local).AddTicks(9348), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("61a42a8e-93ff-4a53-922b-5e2eb66da657"), false, "BA", null, null, new DateTime(2023, 10, 3, 6, 55, 51, 867, DateTimeKind.Utc).AddTicks(9373), null, "Rajshahi University", new DateTime(2028, 10, 3, 12, 55, 51, 867, DateTimeKind.Local).AddTicks(9374), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("7b392925-619c-44a1-a694-8428588ed3ca"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("56a4e7cf-d368-4208-b464-8ca3e82d1764") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("1bd4d92e-d1b5-4af0-a8b5-9aa4542d2668"), false, false, false, new Guid("6298d058-d2f1-4cc7-bc20-f3a8b59b86f0"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("25de5207-1fa2-451a-8457-cd19d102325c"), false, false, false, new Guid("2d47ee3e-d803-4567-8ccd-a738a1d0e8a9"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("191ef286-b9b2-4c3f-b680-e157db84d5db"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("3788e2d1-3a2d-4281-89e6-fede139d342e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" },
                    { new Guid("f0c82070-4563-4a71-8a73-7beb6c42830e"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("4529e9a6-8c48-418d-a57f-22ddb9ae9a0d"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("98061375-adcf-4a11-9573-19f68ee96dca") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("a0c0cd14-8db2-478b-8db4-92f5d6ae0721"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 12, 55, 51, 868, DateTimeKind.Local).AddTicks(309), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 18, 55, 51, 868, DateTimeKind.Local).AddTicks(310), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("fb29fa5b-4cd8-42ef-99c0-39960c46dfa0"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 12, 55, 51, 868, DateTimeKind.Local).AddTicks(280), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 8, 55, 51, 868, DateTimeKind.Local).AddTicks(282), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_MemberId",
                table: "Admins",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Admins_MemberId",
                table: "Admins");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("74f6c753-8e44-4e4e-89e6-f60eac62760f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("715018cd-13d4-4b55-9df3-4d816307a1af"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("67cd293f-a5ca-40c9-81c4-82328aadac25"));

            migrationBuilder.DeleteData(
                table: "CoverPhotos",
                keyColumn: "Id",
                keyValue: new Guid("b339b7f4-0c36-4509-8abc-2bc7b5d18b13"));

            migrationBuilder.DeleteData(
                table: "DoctorComments",
                keyColumn: "Id",
                keyValue: new Guid("3ff39c55-fbdc-4e41-afe1-1c9ad38b58ed"));

            migrationBuilder.DeleteData(
                table: "DoctorFollowers",
                keyColumn: "Id",
                keyValue: new Guid("ba2fa72a-4c6f-4c7f-9c7c-807688c766ae"));

            migrationBuilder.DeleteData(
                table: "DoctorRequests",
                keyColumn: "Id",
                keyValue: new Guid("ba377e80-1e1c-4e1b-9cbf-51c146520511"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5079c7e5-a95e-4922-8adf-3577df24765d"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("61a42a8e-93ff-4a53-922b-5e2eb66da657"));

            migrationBuilder.DeleteData(
                table: "FriendRequests",
                keyColumn: "Id",
                keyValue: new Guid("7b392925-619c-44a1-a694-8428588ed3ca"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("1bd4d92e-d1b5-4af0-a8b5-9aa4542d2668"));

            migrationBuilder.DeleteData(
                table: "Friends",
                keyColumn: "Id",
                keyValue: new Guid("25de5207-1fa2-451a-8457-cd19d102325c"));

            migrationBuilder.DeleteData(
                table: "PatientComplains",
                keyColumn: "Id",
                keyValue: new Guid("191ef286-b9b2-4c3f-b680-e157db84d5db"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("3788e2d1-3a2d-4281-89e6-fede139d342e"));

            migrationBuilder.DeleteData(
                table: "ProfilePhotos",
                keyColumn: "Id",
                keyValue: new Guid("f0c82070-4563-4a71-8a73-7beb6c42830e"));

            migrationBuilder.DeleteData(
                table: "SendingRequests",
                keyColumn: "Id",
                keyValue: new Guid("4529e9a6-8c48-418d-a57f-22ddb9ae9a0d"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("a0c0cd14-8db2-478b-8db4-92f5d6ae0721"));

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: new Guid("fb29fa5b-4cd8-42ef-99c0-39960c46dfa0"));

            migrationBuilder.DropColumn(
                name: "AdminType",
                table: "Admins");

            migrationBuilder.AddColumn<bool>(
                name: "CEO",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GeneralAdmin",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SuperAdmin",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "MemberId", "ParmanentAdress", "PresentAddress" },
                values: new object[] { new Guid("b6f8204f-a5a4-48fb-86d7-33729aab045f"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "Pabna", "Kushtia" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CEO", "GeneralAdmin", "MemberId", "SuperAdmin" },
                values: new object[] { new Guid("d0771ae1-7b9e-446b-ac77-a6380440be63"), false, false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"),
                column: "ConcurrencyStamp",
                value: "3f3a34e2-8532-4bc7-a198-87131a61c784");

            migrationBuilder.InsertData(
                table: "CoverPhotos",
                columns: new[] { "Id", "CoverPhotoLink", "Ispresent", "MemberId" },
                values: new object[,]
                {
                    { new Guid("be5e9a29-1cb5-4c85-b195-4a9187fb5f80"), "www.colud.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("ccc2494f-6238-4dda-b460-1ed31b00f6e2"), "www.aws.com", false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.InsertData(
                table: "DoctorComments",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("d23e9bb1-0648-494a-82f6-5973be064707"), "Doctor is very good at surgery ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "DoctorFollowers",
                columns: new[] { "Id", "DoctorId", "FollowerId" },
                values: new object[] { new Guid("44f1c367-69cd-4aef-a11f-8cf291bc12f7"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("315b9967-1466-4381-a05e-44266af0be90") });

            migrationBuilder.InsertData(
                table: "DoctorRequests",
                columns: new[] { "Id", "Accept", "Experties", "FullName", "HscCertificate", "MedicalIdCard", "MedicalSchoolCertificate", "MemberId", "Pending", "Reject", "SSCCertificate", "isSeen" },
                values: new object[] { new Guid("dec65ab6-8c99-4069-81c7-57c8aa83bc99"), false, "Gyne,Chest,bone", "Dr Md Sojib Hosen", "www.aws.com", "www.google.com", "www.amar.com", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), true, false, "www.aws.com", false });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CureentlyRunnig", "Degree", "Description", "DoctorId", "From", "MemberId", "SchoolName", "To", "UserId", "isDelete", "isPrivate" },
                values: new object[,]
                {
                    { new Guid("11bc8b7d-2b97-4066-8f65-40f06bf476db"), false, "Bsc", null, null, new DateTime(2023, 10, 3, 5, 16, 26, 789, DateTimeKind.Utc).AddTicks(506), null, "Islamic University", new DateTime(2028, 10, 3, 11, 16, 26, 789, DateTimeKind.Local).AddTicks(512), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false },
                    { new Guid("f72eacbf-0345-4dcb-b11a-991f9990bad7"), false, "BA", null, null, new DateTime(2023, 10, 3, 5, 16, 26, 789, DateTimeKind.Utc).AddTicks(533), null, "Rajshahi University", new DateTime(2028, 10, 3, 11, 16, 26, 789, DateTimeKind.Local).AddTicks(534), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), false, false }
                });

            migrationBuilder.InsertData(
                table: "FriendRequests",
                columns: new[] { "Id", "IsSeen", "MemberId", "RequestId" },
                values: new object[] { new Guid("576d20bf-d13b-4dc5-94fc-a24bae36005c"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("d132fff2-dd40-4213-894f-d7c079dea26a") });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Id", "Block", "BlockFromFriend", "BlockFromMe", "FriendId", "MemberId", "MessageBlock", "MessageBlockFromFriend", "MessageBlockFromME" },
                values: new object[,]
                {
                    { new Guid("6fe11252-1fd1-4a94-845f-d118e83345cf"), false, false, false, new Guid("eca144c9-6c83-4067-9334-780491cd1a47"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false },
                    { new Guid("74316cad-9e2e-45ce-bfa7-6f60aa77be59"), false, false, false, new Guid("71ad41d7-92ae-430c-b465-01d6902e0529"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), false, false, false }
                });

            migrationBuilder.InsertData(
                table: "PatientComplains",
                columns: new[] { "Id", "Comment", "DoctorId", "PatientId" },
                values: new object[] { new Guid("12fee9be-1198-45af-acf8-c7a3eff84a44"), "Doctor's behave very dangerous ", new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb85"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") });

            migrationBuilder.InsertData(
                table: "ProfilePhotos",
                columns: new[] { "Id", "IsPresent", "MemberId", "profilePhotoLink" },
                values: new object[,]
                {
                    { new Guid("806f066f-efaf-410a-afd9-82258a4eca02"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.aws.com" },
                    { new Guid("f2f46e56-e700-4f35-992c-facc4d247380"), false, new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), "www.colud.com" }
                });

            migrationBuilder.InsertData(
                table: "SendingRequests",
                columns: new[] { "Id", "MemberId", "SendFriendRequestId" },
                values: new object[] { new Guid("11e3107c-484c-4818-a1dd-5da60c29e5be"), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82"), new Guid("9d758fee-9bf3-4514-8cca-ebec64bc841c") });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "ComapnyName", "CurrentlyRunning", "Description", "DoctorId", "From", "IsDelete", "IsPrivate", "MemberId", "Title", "To", "UserId" },
                values: new object[,]
                {
                    { new Guid("051edc91-51cc-4fd9-8dd9-3b0727d19e4f"), "Vivasoft", false, "Descriptiom", null, new DateTime(2023, 10, 3, 11, 16, 26, 789, DateTimeKind.Local).AddTicks(1486), false, false, null, " Software Enginer", new DateTime(2023, 10, 4, 17, 16, 26, 789, DateTimeKind.Local).AddTicks(1487), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") },
                    { new Guid("14e4936e-6804-472b-b4e2-b87167d52788"), "Devskill", false, "Hi this sojib", null, new DateTime(2023, 10, 3, 11, 16, 26, 789, DateTimeKind.Local).AddTicks(1446), false, false, null, "Intern Software Enginer", new DateTime(2023, 10, 4, 7, 16, 26, 789, DateTimeKind.Local).AddTicks(1448), new Guid("0e1c1417-8dc0-4e9d-834d-89a889d2fb82") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_MemberId",
                table: "Admins",
                column: "MemberId");
        }
    }
}

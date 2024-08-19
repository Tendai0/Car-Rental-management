using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class Role_user_seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7", 0, "1299a5c9-599f-4db5-8f08-c7330dd35291", "user@localhost.com", false, "System", "System", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIqDgyO+Ed3kT3Q+P2Q2HCdqZuNIDOHTEmi+d11GjszVDX9SchhZ2w94zlAsNX2DnA==", null, false, "92dae1a2-1d1b-4e9b-a382-afe41c5faba8", false, "user@localhost.com" },
                    { "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7", 0, "fac9109d-9247-4cda-85f8-7ba9c159dadd", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFPJnO7QBWubZ8St05QBKxboDggQriDKfDJVLcaJJ4qXwty5qMRTzmO1w+5LdPmPLA==", null, false, "5e425674-48c1-4b66-96a8-8cac43395453", false, "admin@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6227), new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 8, 20, 0, 4, 29, 801, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6725), new DateTime(2024, 8, 19, 22, 4, 29, 801, DateTimeKind.Utc).AddTicks(6725) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7", "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7" },
                    { "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7", "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7", "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7", "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfjd-y67e-4433-gyff-6fg5-456yt-756jtu7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfjd-y67e-4433-gyff-6fg5t-456yt-756jtu7");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(2423), new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(2454), new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(3160), new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(3165), new DateTime(2024, 8, 19, 23, 38, 2, 743, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3359), new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3363), new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 8, 19, 21, 38, 2, 743, DateTimeKind.Utc).AddTicks(3366) });
        }
    }
}

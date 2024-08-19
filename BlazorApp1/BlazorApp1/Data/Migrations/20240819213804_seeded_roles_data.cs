using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class seeded_roles_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7", null, "User", "USER" },
                    { "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7", null, "Administrator", "ADMINISTRATOR" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfjfd-y676-4433-gyff-6g5t-456yt-756jtu7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfjfd-y676e-4433-gyff-6fg5t-456yt-756jtu7");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8775), new DateTime(2024, 8, 19, 23, 10, 43, 427, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8878), new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8882), new DateTime(2024, 8, 19, 21, 10, 43, 427, DateTimeKind.Utc).AddTicks(8882) });
        }
    }
}

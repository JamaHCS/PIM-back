using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class orderOnPermission4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                schema: "pim",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "Icon",
                value: "pi pi-users");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "Icon",
                value: "pi pi-users");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "Icon",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 7, 21, 21, 495, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "829fbc38-f8b6-4c0b-a67f-491cda764129", new DateTime(2025, 2, 8, 7, 21, 21, 494, DateTimeKind.Utc).AddTicks(7833), "AQAAAAIAAYagAAAAEIxQjOG3bjPnoypDqQXvlfnSnrSHrGUOq7SsM6QSSxs/r8pdKQNj9cuZphDWgq+0CA==", "aa877369-59e7-40ba-a976-a0be2342e0a7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                schema: "pim",
                table: "Permissions");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 7, 10, 2, 191, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae8b1d1d-2645-458b-9d8d-99e46fd08cf7", new DateTime(2025, 2, 8, 7, 10, 2, 190, DateTimeKind.Utc).AddTicks(6758), "AQAAAAIAAYagAAAAEEIGXLGrDNCD5tSj4V+YI0YOcgjboBjTH4G2b3m4t5SdaZabW4sOCsNR6Y7c3Qzs0g==", "37d66eeb-044f-4d10-9e3c-884eff5be74b" });
        }
    }
}

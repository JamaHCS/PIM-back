using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class labelOnPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Label",
                schema: "pim",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "Label",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "Label",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "Label",
                value: "Usuarios");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "Label",
                value: "Roles");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "Label",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "Label",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "Label",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 6, 55, 34, 854, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd25675-42d7-4952-818d-ca259fb24cfd", new DateTime(2025, 2, 8, 6, 55, 34, 854, DateTimeKind.Utc).AddTicks(4172), "AQAAAAIAAYagAAAAEHYFb7FFo/Gw5RfTX0lf2nezc6ZHuGGPedzjqNoxqUDLx94P8Rf63sz6zbQTQO/EBA==", "cea3571a-94fb-4a84-8252-773e179257c8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Label",
                schema: "pim",
                table: "Permissions");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 6, 46, 20, 236, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0c8c6f-7546-416e-8ce8-59a7bb40ef4a", new DateTime(2025, 2, 8, 6, 46, 20, 235, DateTimeKind.Utc).AddTicks(7629), "AQAAAAIAAYagAAAAEMBDd1pS74e0AFPsw2+0Fj3SpUb7BfmhCzP9jE0fSB6nJpEA85H6eJfNluVSrnO4ug==", "8997a069-9761-4783-8f9a-73a86e783e6d" });
        }
    }
}

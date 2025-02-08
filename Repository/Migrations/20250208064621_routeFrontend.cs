using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class routeFrontend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "pim",
                table: "RolePermissions",
                keyColumns: new[] { "AppRoleId", "PermissionId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-1000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") });

            migrationBuilder.DeleteData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "FrontendRoute",
                schema: "pim",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "FrontendRoute",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "FrontendRoute",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "FrontendRoute",
                value: "users");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "FrontendRoute",
                value: "roles");

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "FrontendRoute",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "FrontendRoute",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "FrontendRoute",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrontendRoute",
                schema: "pim",
                table: "Permissions");

            migrationBuilder.InsertData(
                schema: "pim",
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("00000000-0000-0000-0004-000000000000"), "Permite leer la información de los permisos.", "getPermissions" });

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 1, 26, 8, 1, 45, 838, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "818efc34-cc79-447c-8fcf-f24059256079", new DateTime(2025, 1, 26, 8, 1, 45, 838, DateTimeKind.Utc).AddTicks(3837), "AQAAAAIAAYagAAAAEKC2+rO/jFpD6AT+d5lCxWMi0SkGGW/kNG+vluQbgmHR6SxX1R2t0ALzM9uVo3pCXw==", "cf9a1212-d115-4956-b31e-605ee1a1dced" });

            migrationBuilder.InsertData(
                schema: "pim",
                table: "RolePermissions",
                columns: new[] { "AppRoleId", "PermissionId" },
                values: new object[] { new Guid("00000000-0000-0000-1000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") });
        }
    }
}

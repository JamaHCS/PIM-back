using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class orderOnPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                schema: "pim",
                table: "Permissions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0007-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0008-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0009-000000000000"),
                column: "Order",
                value: null);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 7, 4, 31, 597, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0af0d527-7d7b-4a3b-923b-b93544259cfd", new DateTime(2025, 2, 8, 7, 4, 31, 596, DateTimeKind.Utc).AddTicks(9860), "AQAAAAIAAYagAAAAEMISaVsC2e2WWLMnNBir0SG18OOnB0a6tgxRxKb5HN3NtS3vdgFepjJXF2FoU5c55A==", "ccaa4aa8-a4b1-4aa0-9238-061a5fe40789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                schema: "pim",
                table: "Permissions");

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
    }
}

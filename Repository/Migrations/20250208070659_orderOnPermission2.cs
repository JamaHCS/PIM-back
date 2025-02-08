using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class orderOnPermission2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "Order",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0006-000000000000"),
                column: "Order",
                value: 3);

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-1000-000000000000"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 8, 7, 6, 58, 386, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "pim",
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdc41983-8c74-4b22-8aaf-7110adccf718", new DateTime(2025, 2, 8, 7, 6, 58, 385, DateTimeKind.Utc).AddTicks(7548), "AQAAAAIAAYagAAAAEH/u9hOjCJhzT2vSnF4feNzA211NIYLnJlt6Z3mWi0ShaJdhV5d2MnQFm0UoGH30LA==", "61586f4b-5bf3-4b06-b09c-703b0f5a2c58" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPages.Migrations
{
    public partial class Annotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 51, 47, 784, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 51, 47, 787, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 51, 47, 787, DateTimeKind.Local).AddTicks(8541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 4, 10, 845, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 4, 10, 850, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "ClientService",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 10, 10, 22, 4, 10, 850, DateTimeKind.Local).AddTicks(2430));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSMS_asp.net.Migrations
{
    public partial class fix_seeding_aspnetroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35ad3cc4-b118-416b-881c-37ff6de075bf",
                column: "Name",
                value: "Manager");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b88addd-d4bf-4ea5-b777-70753617f2e9",
                column: "Name",
                value: "Staff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40352054-6ef4-4be4-8c4f-b3a216bba268",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFp/etVZfqxWMu9uLBz/b90d5VIUMltyD0nT6UsVbmY++Pr9AJEgjKMNH915WVf3Tw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45eeeec2-99b2-4115-9d96-481c08bcf984",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFJJ2xeu5YfVJqPo0ZwTjgXDH3BakYNaSJFBrHSUhql+9BuKEiAlnLqeKa2Gel+r0Q==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDateTime",
                value: new DateTime(2023, 1, 30, 21, 56, 18, 502, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDateTime",
                value: new DateTime(2023, 1, 30, 21, 56, 18, 502, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 56, 18, 502, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 56, 18, 502, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 56, 18, 502, DateTimeKind.Local).AddTicks(1588));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35ad3cc4-b118-416b-881c-37ff6de075bf",
                column: "Name",
                value: "manager");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b88addd-d4bf-4ea5-b777-70753617f2e9",
                column: "Name",
                value: "staff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40352054-6ef4-4be4-8c4f-b3a216bba268",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEMAwHhB4/zw9URUAzIXF0n1aS4fPS9kBOQI7ixUiT0CMm68SLdxk5JZ1Gjizeizr5w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45eeeec2-99b2-4115-9d96-481c08bcf984",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJIUSkPjjZQm2Fx5O7U89pCO9sKb4LedPl57vbrw3/blBMGNfYrp1kqN6leCV2Q7Kg==");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDateTime",
                value: new DateTime(2023, 1, 30, 21, 28, 1, 814, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDateTime",
                value: new DateTime(2023, 1, 30, 21, 28, 1, 814, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 28, 1, 814, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 28, 1, 814, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedAt",
                value: new DateTime(2023, 1, 30, 21, 28, 1, 814, DateTimeKind.Local).AddTicks(2809));
        }
    }
}

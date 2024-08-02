using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Database.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DOB", "StudentAddress", "StudentEmail", "StudentName", "StudentPhone", "StudentlastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "India", "roohi.sharma@hotmail.com", "Roohi", 587123210, "Sharma" },
                    { 2, new DateTime(2008, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "john_philip@yahoo.com", "John", 187121210, "Philip" },
                    { 3, new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Africa", "Maria@gmail.com", "Maria", 102251110, "Wiliam" },
                    { 4, new DateTime(2007, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "UK", "jeck@gmail.com", "Jeck", 447122274, "Gurge" },
                    { 5, new DateTime(2002, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "UAE", "jeck@gmail.com", "Al Makhtum", 998422274, "Haider" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

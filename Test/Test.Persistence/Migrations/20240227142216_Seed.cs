using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductSaleLines",
                columns: new[] { "ProductId", "SalesLineId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 5 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 1 },
                    { 7, 2 },
                    { 8, 4 },
                    { 9, 3 },
                    { 10, 2 },
                    { 11, 3 },
                    { 12, 2 },
                    { 13, 5 },
                    { 14, 4 },
                    { 15, 1 },
                    { 16, 2 },
                    { 17, 5 },
                    { 18, 1 },
                    { 19, 2 },
                    { 20, 1 },
                    { 21, 5 },
                    { 22, 4 },
                    { 23, 1 },
                    { 24, 3 },
                    { 25, 5 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 1 },
                    { 29, 4 },
                    { 30, 2 },
                    { 31, 5 },
                    { 32, 5 },
                    { 33, 5 },
                    { 34, 1 },
                    { 35, 2 },
                    { 36, 4 },
                    { 37, 1 },
                    { 38, 5 },
                    { 39, 2 },
                    { 40, 1 },
                    { 41, 2 },
                    { 42, 1 },
                    { 43, 1 },
                    { 44, 5 },
                    { 45, 3 },
                    { 46, 4 },
                    { 47, 4 },
                    { 48, 4 },
                    { 49, 2 },
                    { 50, 1 },
                    { 51, 1 },
                    { 52, 4 },
                    { 53, 1 },
                    { 54, 5 },
                    { 55, 3 },
                    { 56, 1 },
                    { 57, 3 },
                    { 58, 5 },
                    { 59, 1 },
                    { 60, 1 },
                    { 61, 1 },
                    { 62, 1 },
                    { 63, 5 },
                    { 64, 1 },
                    { 65, 3 },
                    { 66, 1 },
                    { 67, 1 },
                    { 68, 3 },
                    { 69, 3 },
                    { 70, 4 },
                    { 71, 1 },
                    { 72, 2 },
                    { 73, 2 },
                    { 74, 1 },
                    { 75, 3 },
                    { 76, 4 },
                    { 77, 5 },
                    { 78, 3 },
                    { 79, 4 },
                    { 80, 3 },
                    { 81, 1 },
                    { 82, 4 },
                    { 83, 1 },
                    { 84, 1 },
                    { 85, 3 },
                    { 86, 2 },
                    { 87, 1 },
                    { 88, 2 },
                    { 89, 3 },
                    { 90, 3 },
                    { 91, 4 },
                    { 92, 2 },
                    { 93, 4 },
                    { 94, 5 },
                    { 95, 2 },
                    { 96, 5 },
                    { 97, 3 },
                    { 98, 5 },
                    { 99, 4 },
                    { 100, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 52, 15, 632, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "CreateDate", "FirstName", "LastName", "SalesLineId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1111), "FirstName 1", "LastName 1", 4 },
                    { 2, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1133), "FirstName 2", "LastName 2", 5 },
                    { 3, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1144), "FirstName 3", "LastName 3", 1 },
                    { 4, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1150), "FirstName 4", "LastName 4", 5 },
                    { 5, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1156), "FirstName 5", "LastName 5", 5 },
                    { 6, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1163), "FirstName 6", "LastName 6", 5 },
                    { 7, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1170), "FirstName 7", "LastName 7", 3 },
                    { 8, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1176), "FirstName 8", "LastName 8", 4 },
                    { 9, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1180), "FirstName 9", "LastName 9", 5 },
                    { 10, new DateTime(2024, 2, 27, 17, 52, 15, 633, DateTimeKind.Local).AddTicks(1188), "FirstName 10", "LastName 10", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 13, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 21, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 23, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 26, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 27, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 28, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 29, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 34, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 39, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 40, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 43, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 44, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 46, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 47, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 48, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 49, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 50, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 52, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 53, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 54, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 55, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 57, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 58, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 60, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 62, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 64, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 65, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 66, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 68, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 69, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 70, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 71, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 74, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 75, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 76, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 77, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 78, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 79, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 80, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 82, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 84, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 86, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 87, 1 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 88, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 89, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 90, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 91, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 92, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 93, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 94, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 95, 2 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 96, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 99, 4 });

            migrationBuilder.DeleteData(
                table: "ProductSaleLines",
                keyColumns: new[] { "ProductId", "SalesLineId" },
                keyValues: new object[] { 100, 4 });

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreateDate",
                value: new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4714));
        }
    }
}

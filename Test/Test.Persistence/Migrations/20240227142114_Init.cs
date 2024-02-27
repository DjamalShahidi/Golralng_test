using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSaleLines",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SalesLineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSaleLines", x => new { x.ProductId, x.SalesLineId });
                    table.ForeignKey(
                        name: "FK_ProductSaleLines_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSaleLines_SalesLines_SalesLineId",
                        column: x => x.SalesLineId,
                        principalTable: "SalesLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalesLineId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_SalesLines_SalesLineId",
                        column: x => x.SalesLineId,
                        principalTable: "SalesLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreInvoiceHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesLineId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreInvoiceHeaders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreInvoiceHeaders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreInvoiceHeaders_SalesLines_SalesLineId",
                        column: x => x.SalesLineId,
                        principalTable: "SalesLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreInvoiceHeaders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreInvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PreInvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreInvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreInvoiceDetails_PreInvoiceHeaders_PreInvoiceHeaderId",
                        column: x => x.PreInvoiceHeaderId,
                        principalTable: "PreInvoiceHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreInvoiceDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreInvoiceHeaderId = table.Column<int>(type: "int", nullable: false),
                    PreInvoiceDetailId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_PreInvoiceDetails_PreInvoiceDetailId",
                        column: x => x.PreInvoiceDetailId,
                        principalTable: "PreInvoiceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Discounts_PreInvoiceHeaders_PreInvoiceHeaderId",
                        column: x => x.PreInvoiceHeaderId,
                        principalTable: "PreInvoiceHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4285), "Product 1" },
                    { 2, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4320), "Product 2" },
                    { 3, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4325), "Product 3" },
                    { 4, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4329), "Product 4" },
                    { 5, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4332), "Product 5" },
                    { 6, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4337), "Product 6" },
                    { 7, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4340), "Product 7" },
                    { 8, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4344), "Product 8" },
                    { 9, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4348), "Product 9" },
                    { 10, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4353), "Product 10" },
                    { 11, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4357), "Product 11" },
                    { 12, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4359), "Product 12" },
                    { 13, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4362), "Product 13" },
                    { 14, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4410), "Product 14" },
                    { 15, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4413), "Product 15" },
                    { 16, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4416), "Product 16" },
                    { 17, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4419), "Product 17" },
                    { 18, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4423), "Product 18" },
                    { 19, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4426), "Product 19" },
                    { 20, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4429), "Product 20" },
                    { 21, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4432), "Product 21" },
                    { 22, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4435), "Product 22" },
                    { 23, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4438), "Product 23" },
                    { 24, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4441), "Product 24" },
                    { 25, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4444), "Product 25" },
                    { 26, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4446), "Product 26" },
                    { 27, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4449), "Product 27" },
                    { 28, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4452), "Product 28" },
                    { 29, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4454), "Product 29" },
                    { 30, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4457), "Product 30" },
                    { 31, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4460), "Product 31" },
                    { 32, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4462), "Product 32" },
                    { 33, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4465), "Product 33" },
                    { 34, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4468), "Product 34" },
                    { 35, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4471), "Product 35" },
                    { 36, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4474), "Product 36" },
                    { 37, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4476), "Product 37" },
                    { 38, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4479), "Product 38" },
                    { 39, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4482), "Product 39" },
                    { 40, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4484), "Product 40" },
                    { 41, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4487), "Product 41" },
                    { 42, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4489), "Product 42" },
                    { 43, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4492), "Product 43" },
                    { 44, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4494), "Product 44" },
                    { 45, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4497), "Product 45" },
                    { 46, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4500), "Product 46" },
                    { 47, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4503), "Product 47" },
                    { 48, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4538), "Product 48" },
                    { 49, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4541), "Product 49" },
                    { 50, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4543), "Product 50" },
                    { 51, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4546), "Product 51" },
                    { 52, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4549), "Product 52" },
                    { 53, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4552), "Product 53" },
                    { 54, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4555), "Product 54" },
                    { 55, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4558), "Product 55" },
                    { 56, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4560), "Product 56" },
                    { 57, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4564), "Product 57" },
                    { 58, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4566), "Product 58" },
                    { 59, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4569), "Product 59" },
                    { 60, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4572), "Product 60" },
                    { 61, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4574), "Product 61" },
                    { 62, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4577), "Product 62" },
                    { 63, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4580), "Product 63" },
                    { 64, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4583), "Product 64" },
                    { 65, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4585), "Product 65" },
                    { 66, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4588), "Product 66" },
                    { 67, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4591), "Product 67" },
                    { 68, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4594), "Product 68" },
                    { 69, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4597), "Product 69" },
                    { 70, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4600), "Product 70" },
                    { 71, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4602), "Product 71" },
                    { 72, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4605), "Product 72" },
                    { 73, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4607), "Product 73" },
                    { 74, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4610), "Product 74" },
                    { 75, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4612), "Product 75" },
                    { 76, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4615), "Product 76" },
                    { 77, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4618), "Product 77" },
                    { 78, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4621), "Product 78" },
                    { 79, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4624), "Product 79" },
                    { 80, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4627), "Product 80" },
                    { 81, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4660), "Product 81" },
                    { 82, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4663), "Product 82" },
                    { 83, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4666), "Product 83" },
                    { 84, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4670), "Product 84" },
                    { 85, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4673), "Product 85" },
                    { 86, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4677), "Product 86" },
                    { 87, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4679), "Product 87" },
                    { 88, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4681), "Product 88" },
                    { 89, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4683), "Product 89" },
                    { 90, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4686), "Product 90" },
                    { 91, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4689), "Product 91" },
                    { 92, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4692), "Product 92" },
                    { 93, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4694), "Product 93" },
                    { 94, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4697), "Product 94" },
                    { 95, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4699), "Product 95" },
                    { 96, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4702), "Product 96" },
                    { 97, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4705), "Product 97" },
                    { 98, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4708), "Product 98" },
                    { 99, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4711), "Product 99" },
                    { 100, new DateTime(2024, 2, 27, 17, 51, 14, 441, DateTimeKind.Local).AddTicks(4714), "Product 100" }
                });

            migrationBuilder.InsertData(
                table: "SalesLines",
                columns: new[] { "Id", "CreateDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line 1" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line 2" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line 3" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line 4" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Line 5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_PreInvoiceDetailId",
                table: "Discounts",
                column: "PreInvoiceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_PreInvoiceHeaderId",
                table: "Discounts",
                column: "PreInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PreInvoiceDetails_PreInvoiceHeaderId",
                table: "PreInvoiceDetails",
                column: "PreInvoiceHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_PreInvoiceDetails_ProductId",
                table: "PreInvoiceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PreInvoiceHeaders_CustomerId",
                table: "PreInvoiceHeaders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PreInvoiceHeaders_SalesLineId",
                table: "PreInvoiceHeaders",
                column: "SalesLineId");

            migrationBuilder.CreateIndex(
                name: "IX_PreInvoiceHeaders_SellerId",
                table: "PreInvoiceHeaders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleLines_SalesLineId",
                table: "ProductSaleLines",
                column: "SalesLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_SalesLineId",
                table: "Sellers",
                column: "SalesLineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "ProductSaleLines");

            migrationBuilder.DropTable(
                name: "PreInvoiceDetails");

            migrationBuilder.DropTable(
                name: "PreInvoiceHeaders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "SalesLines");
        }
    }
}

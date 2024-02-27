using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

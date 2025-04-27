using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Headers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BioDef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InciName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cas = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fema = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Einecs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeadersH",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderHNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderHName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadersH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadersH_Headers_HeaderId",
                        column: x => x.HeaderId,
                        principalTable: "Headers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeadersHD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderHDNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderHDName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadersHId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadersHD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadersHD_HeadersH_HeadersHId",
                        column: x => x.HeadersHId,
                        principalTable: "HeadersH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HeadersData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadersHId = table.Column<int>(type: "int", nullable: false),
                    HeadersHDId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadersData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadersData_HeadersHD_HeadersHDId",
                        column: x => x.HeadersHDId,
                        principalTable: "HeadersHD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeadersData_HeadersH_HeadersHId",
                        column: x => x.HeadersHId,
                        principalTable: "HeadersH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HeadersData_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeadersData_HeadersHDId",
                table: "HeadersData",
                column: "HeadersHDId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadersData_HeadersHId",
                table: "HeadersData",
                column: "HeadersHId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadersData_ProductId",
                table: "HeadersData",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadersH_HeaderId",
                table: "HeadersH",
                column: "HeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadersHD_HeadersHId",
                table: "HeadersHD",
                column: "HeadersHId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeadersData");

            migrationBuilder.DropTable(
                name: "HeadersHD");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "HeadersH");

            migrationBuilder.DropTable(
                name: "Headers");
        }
    }
}

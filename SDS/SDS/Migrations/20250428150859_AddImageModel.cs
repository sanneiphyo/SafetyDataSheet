using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDS.Migrations
{
    /// <inheritdoc />
    public partial class AddImageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeaderHImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderHId = table.Column<int>(type: "int", nullable: false),
                    HeadersHId = table.Column<int>(type: "int", nullable: false),
                    HeadersDataId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderHImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderHImages_HeadersData_HeadersDataId",
                        column: x => x.HeadersDataId,
                        principalTable: "HeadersData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeaderHImages_HeadersH_HeadersHId",
                        column: x => x.HeadersHId,
                        principalTable: "HeadersH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeaderHImages_HeadersDataId",
                table: "HeaderHImages",
                column: "HeadersDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderHImages_HeadersHId",
                table: "HeaderHImages",
                column: "HeadersHId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeaderHImages");
        }
    }
}

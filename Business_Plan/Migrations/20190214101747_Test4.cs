using Microsoft.EntityFrameworkCore.Migrations;

namespace Business_Plan.Migrations
{
    public partial class Test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItem_CompanyDto_CompanyId",
                table: "ProductItem");

            migrationBuilder.DropIndex(
                name: "IX_ProductItem_CompanyId",
                table: "ProductItem");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ProductItem");

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "CompanyDto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDto_Product",
                table: "CompanyDto",
                column: "Product",
                unique: true,
                filter: "[Product] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDto_ProductItem_Product",
                table: "CompanyDto",
                column: "Product",
                principalTable: "ProductItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDto_ProductItem_Product",
                table: "CompanyDto");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDto_Product",
                table: "CompanyDto");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "CompanyDto");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ProductItem",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_CompanyId",
                table: "ProductItem",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_CompanyDto_CompanyId",
                table: "ProductItem",
                column: "CompanyId",
                principalTable: "CompanyDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

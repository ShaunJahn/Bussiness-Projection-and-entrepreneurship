using Microsoft.EntityFrameworkCore.Migrations;

namespace Business_Plan.Migrations
{
    public partial class Test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TotalCostOfProductDto_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto");

            migrationBuilder.DropIndex(
                name: "IX_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto");

            migrationBuilder.DropColumn(
                name: "TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto");

            migrationBuilder.AddColumn<string>(
                name: "Month",
                table: "TotalCostOfProductDto",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutBasicsUnitCosts_TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts",
                column: "TotalCostOfProductDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutBasicsUnitCosts_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts",
                column: "TotalCostOfProductDtoId",
                principalTable: "TotalCostOfProductDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutBasicsUnitCosts_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts");

            migrationBuilder.DropIndex(
                name: "IX_ProdutBasicsUnitCosts_TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "TotalCostOfProductDto");

            migrationBuilder.DropColumn(
                name: "TotalCostOfProductDtoId",
                table: "ProdutBasicsUnitCosts");

            migrationBuilder.AddColumn<int>(
                name: "TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto",
                column: "TotalCostOfProductDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TotalCostOfProductDto_TotalCostOfProductDto_TotalCostOfProductDtoId",
                table: "TotalCostOfProductDto",
                column: "TotalCostOfProductDtoId",
                principalTable: "TotalCostOfProductDto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

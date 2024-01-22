using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webAPI02.Migrations
{
    /// <inheritdoc />
    public partial class RelaçãoVendaItens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "VendaItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutosId",
                table: "VendaItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VendaId",
                table: "VendaItens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VendaItens_ProdutosId",
                table: "VendaItens",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_VendaItens_VendaId",
                table: "VendaItens",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaItens_Produtos_ProdutosId",
                table: "VendaItens",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaItens_Vendas_VendaId",
                table: "VendaItens",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaItens_Produtos_ProdutosId",
                table: "VendaItens");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaItens_Vendas_VendaId",
                table: "VendaItens");

            migrationBuilder.DropIndex(
                name: "IX_VendaItens_ProdutosId",
                table: "VendaItens");

            migrationBuilder.DropIndex(
                name: "IX_VendaItens_VendaId",
                table: "VendaItens");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "VendaItens");

            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "VendaItens");

            migrationBuilder.DropColumn(
                name: "VendaId",
                table: "VendaItens");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeBar.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class ConfiguracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBGarcom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGarcom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Garcom_Id = table.Column<int>(type: "int", nullable: false),
                    Produto_Id = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBGarcom",
                        column: x => x.Garcom_Id,
                        principalTable: "TBGarcom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBProduto",
                        column: x => x.Produto_Id,
                        principalTable: "TBProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Garcom_Id",
                table: "TBPedido",
                column: "Garcom_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_Produto_Id",
                table: "TBPedido",
                column: "Produto_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPedido");

            migrationBuilder.DropTable(
                name: "TBGarcom");

            migrationBuilder.DropTable(
                name: "TBProduto");
        }
    }
}

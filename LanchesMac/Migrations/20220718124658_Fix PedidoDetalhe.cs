using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class FixPedidoDetalhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LancheId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes");

            migrationBuilder.AlterColumn<int>(
                name: "PedidoId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LancheId",
                table: "PedidoDetalhes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Lanches_LancheId",
                table: "PedidoDetalhes",
                column: "LancheId",
                principalTable: "Lanches",
                principalColumn: "LancheId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoDetalhes_Pedidos_PedidoId",
                table: "PedidoDetalhes",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId");
        }
    }
}

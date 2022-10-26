using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioApiCardapio.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Produtos(ProdutoNome,ProdutoValorUnitario,ProdutoQuantidadeEstoque," +
                "ProdutoDataCadastro,CategoriaId) Values('Batata Frita',16.00,15,now(),1)");
            migrationBuilder.Sql("Insert into Produtos(ProdutoNome,ProdutoValorUnitario,ProdutoQuantidadeEstoque," +
                "ProdutoDataCadastro,CategoriaId) Values('Feijoada para 2 pessoas',75.00,20,now(),2)");
            migrationBuilder.Sql("Insert into Produtos(ProdutoNome,ProdutoValorUnitario,ProdutoQuantidadeEstoque," +
                "ProdutoDataCadastro,CategoriaId) Values('Doce Caseiro - 145 ml',10.50,15,now(),4)");
            migrationBuilder.Sql("Insert into Produtos(ProdutoNome,ProdutoValorUnitario,ProdutoQuantidadeEstoque," +
                "ProdutoDataCadastro,CategoriaId) Values('Refrigerante Lata',6.00,15,now(),4)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
        }
    }
}

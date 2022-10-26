using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioApiCardapio.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome) Values('Entradas')");
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome) Values('Pratos Principais')");
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome) Values('Sobremesas')");
            migrationBuilder.Sql("Insert into Categorias(CategoriaNome) Values('Bebidas')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}

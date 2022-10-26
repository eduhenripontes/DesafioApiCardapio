using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DesafioApiCardapio.Models;

    [Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(80)]
    public string? ProdutoNome { get; set; }

    [Required]
    [Column(TypeName ="decimal(10,2)")]
    public decimal ProdutoValorUnitario { get; set; }

    public float ProdutoQuantidadeEstoque { get; set; }
    public DateTime ProdutoDataCadastro { get; set; }
    public int CategoriaId { get; set; }

    [JsonIgnore]
    public Categoria? Categoria { get; set; }

}

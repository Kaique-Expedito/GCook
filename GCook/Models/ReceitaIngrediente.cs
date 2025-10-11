using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GCook.Models;

[Table("ReceitaIngrediente")]
public class ReceitaIngrediente
{
    [Key, Column(Order = 1)]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    public Receita Receita { get; set; }
    [Key, Column(Order = 2)]
    public int IngredientesId { get; set; }
    [ForeignKey("IngredientesId")]
    public Ingredientes Ingredientes { get; set; }
    [StringLength(30)]
    [Required(ErrorMessage = "A Quantidade é obrigatória")]
    public string Quantidade { get; set; }

}

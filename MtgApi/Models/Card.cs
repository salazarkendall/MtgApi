using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "Card")]
public class Card
{
  [Key]
  [Required]
  public int Id { get; set; }

  [Required]
  [MaxLength(50)]
  public string CardName { get; set; } = String.Empty;

  public ICollection<Cards_Colors>? Cards_Colors { get; set; }
  public ICollection<Cards_Types>? Cards_Types { get; set; }
  public ICollection<Cards_Subtypes>? Cards_Subtypes { get; set; }
}
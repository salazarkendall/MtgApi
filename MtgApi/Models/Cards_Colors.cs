using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "Cards_Colors")]
public class Cards_Colors
{
  [Key]
  [Required]
  public int CardId { get; set; }
  [Key]
  [Required]
  public int ColorId { get; set; }
  public Card? Card { get; set; }
  public Color? Color { get; set; }
}
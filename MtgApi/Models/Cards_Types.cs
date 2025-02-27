using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "Cards_Types")]
public class Cards_Types
{
  [Key]
  [Required]
  public int CardId { get; set; }
  [Key]
  [Required]
  public int TypeId { get; set; }
  public Card? Card { get; set; }
  public Type? Type { get; set; }
}
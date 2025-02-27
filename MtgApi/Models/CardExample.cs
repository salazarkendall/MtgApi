using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "CardExample")]
public class CardExample
{
  [Key]
  [Required]
  public int Id { get; set; }
  [Required]
  [MaxLength(200)]
  public string CardName { get; set; } = String.Empty;
  [Required]
  [MaxLength(200)]
  public string CardType { get; set; } = String.Empty;
  [Required]
  [MaxLength(200)]
  public string ColorIdentity { get; set; } = String.Empty;
  [Required]
  [MaxLength(200)]
  public string SubType { get; set; } = String.Empty;
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "Card_Subtypes")]
public class Cards_Subtypes
{
    [Key]
    [Required]
    public int CardId { get; set; }
    [Key]
    [Required]
    public int SubtypeId { get; set; }
    public Card? Card { get; set; }
    public Subtype? Subtype { get; set; }
}
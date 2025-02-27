using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table("Subtype")]
public class Subtype
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string SubtypeName { get; set; } = String.Empty;
    public ICollection<Cards_Subtypes>? Cards_Subtypes { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table("Type")]
public class Type
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string TypeName { get; set; } = String.Empty;
    public ICollection<Cards_Types>? Cards_Types { get; set; }
}
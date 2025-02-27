using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtgApi.Models;

[Table(name: "Color")]
public class Color
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string ColorName { get; set; } = String.Empty;
    public ICollection<Cards_Colors>? Cards_Colors { get; set; }
}

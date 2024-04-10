using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarryFlix.Models;
[Table()]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public sbyte Id { get; set; }
    [Display(Name = "")]
    [Required()]
    public string Name { get; set; }
}

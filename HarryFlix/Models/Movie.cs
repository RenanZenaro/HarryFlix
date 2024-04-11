using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarryFlix.Models;
[Table("Movie")]
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }
    [Display(Name = "Titulo Original")]
    [Required(ErrorMessage = "Por favor, informe o Titulo Original")]
    [StringLength(100, ErrorMessage = "O Titulo Original deve possuir no máximo 100 caracteres")]
    public string OriginalTitle { get; set; }
    
    [Display(Name = "Titulo")]
    [Required(ErrorMessage = "Por favor, informe o Titulo")]
    [StringLength(100, ErrorMessage = "O Titulo deve possuir no máximo 100 caracteres")]
    public string Title { get; set; }
    
    [Display(Name = "Resumo")]
    [StringLength(8000, ErrorMessage = "O Resumo deve possuir no máximo 8000 caracteres")]
    public string Synopsis { get; set; }

    [Column(TypeName = "Year")]
    [Display(Name = "Ano de Estreia")]
    public int16 MovieYear { get; set; }
    
    [Column(TypeName = "smallint(3)")]
    [Display(Name = "Duração (em minutos)")]
    [Required(ErrorMessage = "Por favor, informe a Duração")]
    public int16 MovieYear { get; set; }

    [Display(Name = "Classificação Etária")]
    [Required(ErrorMessage = "Por favor, informe a Classificação Etária")]
    public sbyte AgeRating { get; set; }

    [StringLength(200)]
    [Display(Nome = "Foto")]
    public string Image { get; set; }

    [NotMapped]
    [Display(Name = "Duração")]
    public string HourDuration { get {
        return TimeSpan.FromMinutes(Duration).ToString(@"%h'h 'm'min'")
    } }

    
}

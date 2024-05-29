using System.ComponentModel.DataAnnotations;

namespace HarryFlix.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
    public string Name { get; set; }

    [Display(Name = "Email ou Nome do Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de Usuário")]
    public string Email { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe a data de nascimento")]
    public DateTime Birthday { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    public string Password { get; set; }
    
    [DataType(DataType.Password)]
    [Display(Name = "Confirmar Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    public string ConfirmPassword { get; set; }
}

using System.ComponentModel.DataAnnotations;

namespace HarryFlix.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome do Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de Usuário")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    public string Password { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool RememberMe { get; set; }
    public string ReturnUrl { get; set; }
}

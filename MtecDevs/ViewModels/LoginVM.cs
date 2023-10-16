using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Porfavor, informne seu email ou nome de usuário")]

      public string Email {get; set;}

    [Display(Name = "Senha de Acesso", Prompt = "Informe sua senha")]
    [Required(ErrorMessage = "Porfavor, informe sua senha")]
    [DataType(DataType.Password)]

      public string Senha {get; set;}

    [Display(Name = "Mante Contectado?")]
    [Required(ErrorMessage = "Porfavor, ionformne seu email ou nome de usuário")]
      public bool Lembrar {get; set;} = false;

      public string UrlRetorno {get; set;}
}

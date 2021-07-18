using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finstock_Barreto.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome de Usuário!")]
        [Display(Name = "Usuário: ")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Informe a sua Senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha { get; set; }
        [Display(Name = "Lembrar-me: ")]
        public bool LembrarMe { get; set; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Controle_estoque.web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o usuario!")]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Informe a senha!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
        [Required]
        [Display(Name = "Lembrar me")]
        public bool LembrarMe { get; set;}
    }
}
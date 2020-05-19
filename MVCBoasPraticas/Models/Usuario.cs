using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace MVCBoasPraticas.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Insira uma observação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }
        [Range(18, 70, ErrorMessage = "Idade tem que estar entre 18 e 70 anos!")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente Letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [Remote("LoginUnico", "Usuario", ErrorMessage = "Este login já existe")]       
        public string Login { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória")]
        [Compare("Senha", ErrorMessage = "As senhas não se coincidem")]
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}
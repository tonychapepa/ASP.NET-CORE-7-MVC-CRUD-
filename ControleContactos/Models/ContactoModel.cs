using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ControleContactos.Models
{
    public class ContactoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira seu Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira seu email")]
        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira seu contacto")]
        [Phone(ErrorMessage = "Celular Inválido!")]
        public string Celular { get; set;}
    }
}

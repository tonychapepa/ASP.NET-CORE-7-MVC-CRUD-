using ControleContactos.Enum;
using System.ComponentModel.DataAnnotations;

namespace ControleContactos.Models
{
    public class UsuarioModel
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite seu nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite seu nome")]
        public string Login { get; set;}

        [EmailAddress(ErrorMessage = "Email Inválido")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Digite a senha do usuario")]
        public string Senha { get; set;}

        public PerfilEnum Perfil { get; set;}
        public DateTime DataCadastro {  get; set;}
        public DateTime? DataAtualizao { get; set;}
    }
}

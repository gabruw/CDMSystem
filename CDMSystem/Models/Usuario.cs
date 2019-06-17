using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [MinLength(1)]
        [MaxLength(120)]
        [Required(ErrorMessage = "Necessário adicionar um E-mail ao Usuário.")]
        public string EmailUsuario { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        [Required(ErrorMessage = "Necessário adicionar uma Senha ao Usuário.")]
        public string SenhaUsuario { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        [Required(ErrorMessage = "Necessário adicionar um Nome ao Usuário.")]
        public string NomeUsuario { get; set; }

        [MinLength(1)]
        [MaxLength(200)]
        [Required(ErrorMessage = "Necessário adicionar um Sobrenome ao Usuário.")]
        public string SobrenomeUsuario { get; set; }

        [MinLength(11)]
        [MaxLength(11)]
        [Required(ErrorMessage = "Necessário adicionar um CPF ao Usuário.")]
        public long CpfUsuario { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [Required(ErrorMessage = "Necessário adicionar uma Permissão ao Usuário.")]
        public int PermissaoUsuario { get; set; }
    }
}
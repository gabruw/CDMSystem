using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Usuario : DTODefault
    {
        public Usuario()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        public string EmailUsuario { get; set; }

        public string SenhaUsuario { get; set; }

        public string NomeUsuario { get; set; }

        public string SobrenomeUsuario { get; set; }

        public int CpfUsuario { get; set; }

        public int PermissaoUsuario { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(EmailUsuario))
            {
                AddError("O campo Email do Usuário não foi informado.");
            }

            if (string.IsNullOrEmpty(SenhaUsuario))
            {
                AddError("O campo Senha do Usuário não foi informado.");
            }

            if (string.IsNullOrEmpty(NomeUsuario))
            {
                AddError("O campo Nome do Usuário não foi informado.");
            }

            if (string.IsNullOrEmpty(SobrenomeUsuario))
            {
                AddError("O campo Sobrenome do Usuário não foi informado.");
            }

            if (CpfUsuario.ToString().Length < 11)
            {
                AddError("O campo Cpf do Usuário não foi informado.");
            }

            if (PermissaoUsuario != 1 || PermissaoUsuario != 2)
            {
                AddError("O campo Permissão do Usuário não foi informado.");
            }
        }
    }
}
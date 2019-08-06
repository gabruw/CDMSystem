using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class User : DTODefault
    {
        public User()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        public double IdAddress { get; set; }

        [ForeignKey("IdAddress")]
        public virtual Address UserAddress { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Sex { get; set; }

        public double Cpf { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(this.Name))
            {
                AddError("O campo Nome não foi informado.");
            }

            if (string.IsNullOrEmpty(this.LastName))
            {
                AddError("O campo Sobrenome não foi informado.");
            }

            if (this.Cpf.ToString().Length == 0)
            {
                AddError("O campo Cpf não foi informado.");
            }

            if (this.Cpf.ToString().Length < 11)
            {
                AddError("Falta caracteres no campo Cpf.");
            }

            if (this.BirthDate == null)
            {
                AddError("O campo Data de Nascimento não foi informado.");
            }

            if (string.IsNullOrEmpty(this.Email))
            {
                AddError("O campo Email não foi informado.");
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                AddError("O campo Senha não foi informado.");
            }
        }
    }
}
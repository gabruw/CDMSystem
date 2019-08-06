using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Address : DTODefault
    {
        public Address()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public int Number { get; set; }

        public int Complement { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public double Cep { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(this.Street))
            {
                AddError("O campo Rua não foi informado.");
            }

            if (string.IsNullOrEmpty(this.Neighborhood))
            {
                AddError("O campo Bairro não foi informado.");
            }

            if (this.Number.ToString().Length == 0)
            {
                AddError("O campo Número não foi informado.");
            }

            if (this.Complement.ToString().Length == 0)
            {
                AddError("O campo Complemento não foi informado.");
            }

            if (string.IsNullOrEmpty(this.City))
            {
                AddError("O campo Rua não foi informado.");
            }

            if (string.IsNullOrEmpty(this.Country))
            {
                AddError("O campo Bairro não foi informado.");
            }

            if (string.IsNullOrEmpty(this.State))
            {
                AddError("O campo Estado não foi informado.");
            }

            if (this.Cep.ToString().Length == 0)
            {
                AddError("O campo CEP não foi informado.");
            }

            if (this.Cep.ToString().Length < 8)
            {
                AddError("Falta caracteres no campo CEP.");
            }
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Guild : DTODefault
    {
        public Guild()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGuild { get; set; }

        public string NomeGuild { get; set; }

        public string DescricaoGuild { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeGuild))
            {
                AddError("O campo Nome da Guild não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoGuild))
            {
                AddError("O campo Descrição da Guild não foi informado.");
            }
        }
    }
}
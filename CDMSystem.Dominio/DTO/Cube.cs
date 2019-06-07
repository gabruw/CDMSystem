using System;
using System.Collections.Generic;
using System.Text;

namespace CDMSystem.Dominio.DTO
{
    public class Cube : DTODefault
    {
        public int IdCube { get; set; }

        public string NomeItemCube { get; set; }

        public string DescricaoItemCube { get; set; }

        public int QuantidadeItemCube { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeItemCube))
            {
                AddError("O campo Nome do Item do Cube não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoItemCube))
            {
                AddError("O campo Status do Item do Cube não foi informado.");
            }

            if (QuantidadeItemCube < 0)
            {
                AddError("O campo Quantidade do Item do Cube não foi informado.");
            }
        }
    }
}
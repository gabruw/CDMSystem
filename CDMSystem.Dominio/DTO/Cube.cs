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
            throw new NotImplementedException();
        }
    }
}
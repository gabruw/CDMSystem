using System;

namespace CDMSystem.Dominio.DTO
{
    public class Guild : DTODefault
    {
        public int IdGuild { get; set; }

        public string NomeGuild { get; set; }

        public string DescricaoGuild { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
namespace CDMSystem.Dominio.DTO
{
    public class Core : DTODefault
    {
        public int IdCore { get; set; }

        public int HpCore { get; set; }

        public int MpCore { get; set; }

        public int DmgfCore { get; set; }

        public int DmgmCore { get; set; }

        public int DefCore { get; set; }

        public int FurCore { get; set; }

        public int DetCore { get; set; }

        public int CritCore { get; set; }

        public int AcrCore { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
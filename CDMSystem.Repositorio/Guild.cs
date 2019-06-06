namespace CDMSystem.Repositorio
{
    public class Guild
    {
        public Guild()
        {
            var newGuild = new Dominio.DTO.Guild();

            var guildRepository = new GuildRepository();
            guildRepository.Incluid(newGuild);
        }
    }
}
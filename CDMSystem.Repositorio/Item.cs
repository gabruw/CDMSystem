namespace CDMSystem.Repositorio
{
    public class Item
    {
        public Item()
        {
            var newItem = new Dominio.DTO.Item();

            var itemRepository = new Repository.ItemRepository();
            itemRepository.Incluid(newItem);
        }
    }
}
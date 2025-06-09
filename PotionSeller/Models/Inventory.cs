namespace InventoryService.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Discription { get; set; }
    }
}

namespace Inventory.Models
{
    public class Inventory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Discription { get; set; }
        public required string Type { get; set; }
        public int Amount { get; set; }
    }
}

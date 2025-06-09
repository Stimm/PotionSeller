namespace InventoryService.Dtos
{
    public class WriteInventoryDto
    {
        public required string Name { get; set; }
        public required string Discription { get; set; }
        public required string Type { get; set; }
        public int Amount { get; set; }
    }
}

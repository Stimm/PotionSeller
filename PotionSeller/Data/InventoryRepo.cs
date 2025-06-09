using InventoryService.Models;

namespace InventoryService.Data
{
    public class InventoryRepo : IInventoryRepo
    {
        private readonly AppDbContext _context;

        public InventoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Inventory> GetAllInventories()
        {
            var inventories = _context.Inventory.ToList();

            return inventories;
        }
    }
}

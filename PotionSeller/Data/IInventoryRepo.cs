using InventoryService.Models;

namespace InventoryService.Data
{
    public interface IInventoryRepo
    {
        IEnumerable<Inventory> GetAllInventories();
    }
}

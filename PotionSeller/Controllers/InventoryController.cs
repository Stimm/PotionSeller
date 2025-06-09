using InventoryService.Data;
using InventoryService.Dtos;
using InventoryService.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private readonly IInventoryRepo _repo;

    
    public InventoryController(IInventoryRepo repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ReadInventoryDto>> GetAllInventories()
    {
        Console.WriteLine("---> Get all Inventories EndPoint reached");
        var inventories = _repo.GetAllInventories();

        return Ok(inventories);
    } 
}

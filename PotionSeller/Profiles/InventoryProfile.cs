using AutoMapper;
using InventoryService.Dtos;
using InventoryService.Models;

namespace InventoryService.Profiles
{
    public class InventoryProfile : Profile
    {
        InventoryProfile()
        { 
            CreateMap<Inventory, ReadInventoryDto>();
        }
    }
}

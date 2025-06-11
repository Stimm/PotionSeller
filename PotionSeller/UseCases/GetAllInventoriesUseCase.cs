using AutoMapper;
using InventoryService.Data;
using InventoryService.Dtos;

namespace InventoryService.UseCases
{
    public class GetAllInventoriesUseCase
    {
        private readonly IInventoryRepo _repo;
        private readonly IMapper _mapper;

        public GetAllInventoriesUseCase(IInventoryRepo repo, IMapper map)
        {
            _repo = repo;
            _mapper = map;
        }

        public IEnumerable<ReadInventoryDto> ExacuteAsync()
        {
            var inventories = _repo.GetAllInventories();

            var map = _mapper.Map<IEnumerable<ReadInventoryDto>>(inventories);

            return map;
        }
    }
}

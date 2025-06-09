using AutoMapper;
using InventoryService.Data;
using InventoryService.Dtos;
using InventoryService.Models;
using InventoryService.UseCases;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionSellerTests.InventoryServiceTests.Read
{
    public class GetAllInventoriesTests
    {

        [Fact]
        public void ReturnInventories()
        {
            var inventoryObject = new Inventory() { Id = new Guid(), Name = "Stimm", Discription = "Pack full of viles and gadgits" };
            var inventoryList = new List<Inventory>();
            inventoryList.Add(inventoryObject);

            var ReadInventoryObject = new ReadInventoryDto() { Name = "Stimm", Discription = "Pack full of viles and gadgits", Type = "type" };
            var ReadInventoryList = new List<ReadInventoryDto>();
            ReadInventoryList.Add(ReadInventoryObject);


            var mockedInventoryRepo = new Mock<IInventoryRepo>();
            var mockedInventoryMapper = new Mock<IMapper>();

            mockedInventoryRepo.Setup(m => m.GetAllInventories()).Returns(inventoryList);
            mockedInventoryMapper.Setup(m => m.Map<IEnumerable<ReadInventoryDto>>(It.IsAny<IEnumerable<Inventory>>())).Returns(ReadInventoryList);


            var GetAllInventories = new GetAllInventoriesUseCase(mockedInventoryRepo.Object, mockedInventoryMapper.Object);


            var results = GetAllInventories.ExacuteAsync();

            Assert.Equal(inventoryList.First().Id, results.First().Id);

        }
    }
}

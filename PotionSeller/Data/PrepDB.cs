using InventoryService.Models;
using System.Runtime.CompilerServices;

namespace InventoryService.Data
{
    public static class PrepDB
    {
        public static void PrepDb(IApplicationBuilder app, bool isDevlopment)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedDB(serviceScope.ServiceProvider.GetService<AppDbContext>(), isDevlopment);
            }
        }


        private static void SeedDB(AppDbContext dbContext, bool isDevlopment)
        {
            if (!isDevlopment)
            {
                //todo entity frame work migration    
            }

            if (dbContext.Inventory.Any())
            {
                Console.WriteLine("Db is already populated");
            }
            else
            {
                Console.WriteLine("Seeding data to the DB");
                AddRanges(dbContext);
            }
        }


        private static void AddRanges(AppDbContext dbContext)
        {
            dbContext.Inventory.AddRange(
                new Inventory() { Name = "Stimm", Discription = "Pack full of viles and gadgits" },
                new Inventory() { Name = "Spogren", Discription = "Satchel for holding slaves" },
                new Inventory() { Name = "El'af", Discription = "Bag of bits" }
                );

            dbContext.SaveChanges();
            Console.WriteLine("Data added");

            var inventories = dbContext.Inventory.ToList();
        }
    }
}

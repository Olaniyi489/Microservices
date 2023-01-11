using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "House",
                    Summary = "For Leasing",
                    Description = "This is 3 bedroom bungalow apartment situated at lekki",
                    ImageFile = "Product-1.png",
                    Price = 950.00M,
                    Category = "Housing"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Office",
                    Summary = "For Rent",
                    Description = "A spacious office for daily activities situated at Ogba",
                    ImageFile = "Product-2.png",
                    Price = 750.00M,
                    Category = "Office"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Warehouse",
                    Summary = "For Sale",
                    Description = "A very clean and spacious warehouse for goods situated at Ikoyi",
                    ImageFile = "Product-4.png",
                    Price = 500.00M,
                    Category = "Warehouse"
                },
                 new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Duplex",
                    Summary = "For Sale",
                    Description = "A very clean and spacious duplex for family situated at Ikoyi",
                    ImageFile = "Product-5.png",
                    Price = 1000.00M,
                    Category = "Residential"
                },
                 new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "4 Bedroom Detached Bungalow",
                    Summary = "For Sale",
                    Description = "A very clean and spacious 4 Bedroom Detached Bungalow for peaceful life situated at Ikoyi",
                    ImageFile = "Product-6.png",
                    Price = 800.00M,
                    Category = "Residential"
                },
            };
        }
    }
}

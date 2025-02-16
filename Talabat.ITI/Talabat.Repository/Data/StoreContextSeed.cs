using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Repository.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if (!context.ProductCategories.Any())
            {
                var categoriesData = await File.ReadAllTextAsync("../Talabat.Repository/Data/SeedData/SeedData.json");
                var categories = JsonSerializer.Deserialize<SeedData>(categoriesData)?.ProductCategories;

                if (categories != null)
                {
                    context.ProductCategories.AddRange(categories);
                    await context.SaveChangesAsync();
                }
            }

            if (!context.ProductBrands.Any())
            {
                var brandsData = await File.ReadAllTextAsync("../Talabat.Repository/Data/SeedData/SeedData.json");
                var brands = JsonSerializer.Deserialize<SeedData>(brandsData)?.ProductBrands;

                if (brands != null)
                {
                    context.ProductBrands.AddRange(brands);
                    await context.SaveChangesAsync();
                }
            }

            if (!context.Products.Any())
            {
                var productsData = await File.ReadAllTextAsync("../Talabat.Repository/Data/SeedData/SeedData.json");
                var products = JsonSerializer.Deserialize<SeedData>(productsData)?.Products;

                if (products != null)
                {
                    context.Products.AddRange(products);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}

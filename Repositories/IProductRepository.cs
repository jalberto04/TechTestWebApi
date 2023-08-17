using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechTestWebApi.Dtos;
using TechTestWebApi.Models;

namespace TechTestWebApi.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        
        Task<Product> GetProductByIdAsync(int id);

        Task<Product> CreateProductAsync(Product model);

        Task<Product> UpdateProductAsync(int id, Product model);

        void DeleteProduct(int id);
    }
}

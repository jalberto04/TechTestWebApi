using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TechTestWebApi.Data;
using TechTestWebApi.Dtos;
using TechTestWebApi.Exceptions;
using TechTestWebApi.Models;

namespace TechTestWebApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var dbProducts = await _context.Products.ToListAsync();
            return dbProducts;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var dbProduct = await _context.Products.Where(product => product.Id == id).FirstOrDefaultAsync();
            return dbProduct;
        }

        public async Task<Product> CreateProductAsync(Product model)
        {
            // TODO: implement automapper
            var newProduct = new Product
            {
                Name = model.Name,
                Description = model.Description ?? "",
                Price = model.Price,
            };

            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }

        public async Task<Product> UpdateProductAsync(int id, Product model)
        {
            var dbProduct = await _context.Products.Where(product => product.Id == id).FirstOrDefaultAsync();
            
            // if (dbProduct == null) throw new RecordNotFoundException("Product");
            if (dbProduct == null) return null;

            dbProduct.Name = model.Name;
            dbProduct.Description = model.Description ?? "";
            dbProduct.Price = model.Price;

            _context.Products.Update(dbProduct);
            await _context.SaveChangesAsync();
            return dbProduct;
        }

        public void DeleteProduct(int id)
        {
            _context.Products.Remove(new Product { Id = id });
            _context.SaveChanges();
        }
    }
}

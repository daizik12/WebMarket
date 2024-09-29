using System.Runtime.Serialization.DataContracts;
using WebMarket.Dtos.Product;
using WebMarket.models;

namespace WebMarket.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
        Task<Product?> CreateAsync(Product ProductModel);
        Task<Product?> UpdateAsync(int id, UpdateProductDto ProductModel);
        Task<Product?> DeleteAsync(int id);
    }
}

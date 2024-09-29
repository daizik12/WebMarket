using WebMarket.Interfaces;
using WebMarket.Data;
using WebMarket.models;
using Microsoft.EntityFrameworkCore;
using WebMarket.Dtos.Product;


namespace WebMarket.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)=>_context = context;
        public async Task<Product?> GetByIdAsync(int id) => await _context.products.Include(c => c.Category).Include(c => c.Manufacturer).FirstOrDefaultAsync(i => i.Id == id);
        public async Task<List<Product>> GetAllAsync()
        {
            var products = await _context.products.Include(c => c.Category).ToListAsync();
            return products;
        }
        public async Task<Product?> CreateAsync(Product productmodel)
        {
            await _context.products.AddAsync(productmodel);
            await _context.SaveChangesAsync();
            return productmodel;
        }
        public async Task<Product?> DeleteAsync(int id)
        {
            var productmodel = await _context.products.FirstOrDefaultAsync(i => i.Id == id);
            if (productmodel != null)
            {
                _context.products.Remove(productmodel);
                await _context.SaveChangesAsync();
                return productmodel;
            }
            return null;
        }
        public async Task<Product?> UpdateAsync(int id, UpdateProductDto productdto)
        {
            var existingProduct = await _context.products.FirstOrDefaultAsync(i => i.Id == id);
            if (existingProduct != null)
            {
                existingProduct.Name = productdto.Name;
                existingProduct.Quantity = productdto.Quantity;
                existingProduct.Price = productdto.Price;
            }
            await _context.SaveChangesAsync();
            return existingProduct;
        }
    }
}

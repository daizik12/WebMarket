using WebMarket.Interfaces;
using WebMarket.Data;
using WebMarket.models;
using Microsoft.EntityFrameworkCore;


namespace WebMarket.Repository
{
    public class ProductRepository :IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)=>_context = context;
        public async Task<Product?> GetByIdAsync(int id) => await _context.products.Include(c => c.Category).Include(c => c.Manufacturer).FirstOrDefaultAsync(i => i.Id == id);
        public async Task<List<Product>> GetAllAsync()
        {

        }

    }
}

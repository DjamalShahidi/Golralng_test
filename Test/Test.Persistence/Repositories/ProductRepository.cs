using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    //public class ProductRepository : GenericRepository<Product>, IProductRepository
    //{
    //    private readonly TestDbContext _context;

    //    public ProductRepository(TestDbContext context) : base(context)
    //    {
    //        this._context = context;
    //    }

    //    public async Task<List<Product>> GetProductByCategoryIdAsync(int categoryId)
    //    {
    //        return await _context.Products.Include(a=>a.Category).Where(a => a.CategoryId == categoryId).ToListAsync();
    //    }

    //    public async Task<List<Product>> GetListAsyncWithInclude()
    //    {
    //        return await _context.Products.Include(a => a.Category).ToListAsync();
    //    }
    //}
}

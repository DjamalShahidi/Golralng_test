using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class ProductSaleLineRepository : GenericRepository<ProductSaleLine>, IProductSaleLineRepository
    {
        private readonly TestDbContext _context;

        public ProductSaleLineRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<bool> IsExist(int productId,int saleLineId)
        {
            return await _context.ProductSaleLines.AnyAsync(a => a.SalesLineId == saleLineId && a.ProductId == productId);
        }
    }
}

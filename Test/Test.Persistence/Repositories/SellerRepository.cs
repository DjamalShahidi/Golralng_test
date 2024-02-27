using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class SellerRepository : GenericRepository<Seller>, ISellerRepository
    {
        private readonly TestDbContext _context;

        public SellerRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<bool> IsExist(int sellerId ,int saleLineId)
        {
            return await _context.Sellers.AnyAsync(a => a.Id == sellerId && a.SalesLineId == saleLineId);
        }
    }
}

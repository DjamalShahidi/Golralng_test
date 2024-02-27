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
    }
}

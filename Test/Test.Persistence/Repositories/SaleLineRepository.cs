using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class SaleLineRepository : GenericRepository<SalesLine>, ISaleLineRepository
    {
        private readonly TestDbContext _context;

        public SaleLineRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}

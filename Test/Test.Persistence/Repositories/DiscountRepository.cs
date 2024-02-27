using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class DiscountRepository : GenericRepository<Discount>, IDiscountRepository
    {
        private readonly TestDbContext _context;

        public DiscountRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }

    }
}

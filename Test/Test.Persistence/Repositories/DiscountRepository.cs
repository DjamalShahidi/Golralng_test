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

        public async Task<double> GetTotalDiscount(int preInvoiceHeaderId)
        {
           return await _context.Discounts.Where(a => a.PreInvoiceHeaderId == preInvoiceHeaderId).SumAsync(a => a.Amount);
        }

        public async Task<double> GetFinalTotalDiscount(int customerId)
        {
            return await _context.Discounts.Where(a => a.PreInvoiceHeader.CustomerId == customerId
                                                    && a.PreInvoiceHeader.Status == PreInvoiceHeaderStatus.Final)
                                                   .SumAsync(a => a.Amount);
        }
    }
}

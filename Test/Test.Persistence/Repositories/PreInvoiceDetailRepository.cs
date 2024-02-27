using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class PreInvoiceDetailRepository : GenericRepository<PreInvoiceDetail>, IPreInvoiceDetailRepository
    {
        private readonly TestDbContext _context;

        public PreInvoiceDetailRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<bool> DublicateProduct(int preInvoiceHeaderId, int productId)
        {
            return await _context.PreInvoiceDetails.AnyAsync(a => a.PreInvoiceHeaderId == preInvoiceHeaderId && a.ProductId == productId);
        }
    }
}

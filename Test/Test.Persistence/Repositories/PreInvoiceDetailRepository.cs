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

        public async Task<bool> CheckDublicateProductForAdd(int preInvoiceHeaderId, int productId)
        {
            return await _context.PreInvoiceDetails.AnyAsync(a => a.PreInvoiceHeaderId == preInvoiceHeaderId && a.ProductId == productId);
        }

        public async Task<bool> CheckDublicateProductForUpdate(int preInvoiceHeaderId,int preInvoiceDetailId, int productId)
        {
            return await _context.PreInvoiceDetails.AnyAsync(a => a.PreInvoiceHeaderId == preInvoiceHeaderId && a.ProductId == productId  && a.Id != preInvoiceDetailId);
        }

        public async Task<double> GetTotalPrice(int preInvoiceHeaderId)
        {
            return await _context.PreInvoiceDetails.Where(a => a.PreInvoiceHeaderId == preInvoiceHeaderId).SumAsync(a => a.Price * a.Count);
        }

        public async Task<double> GetFinalTotalPrice(int customerId)
        {
            return await _context.PreInvoiceDetails.Where(a => a.PreInvoiceHeader.CustomerId == customerId 
                                                            && a.PreInvoiceHeader.Status==PreInvoiceHeaderStatus.Final)
                                                   .SumAsync(a => a.Price * a.Count);
        }

        public async Task<bool> IsExistWithThisPreInvoiceHeaderId(int preInvoiceHeaderId)
        {
            return await _context.PreInvoiceDetails.AnyAsync(a => a.PreInvoiceHeaderId == preInvoiceHeaderId );

        }
    }
}

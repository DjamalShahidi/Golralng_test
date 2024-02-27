using Microsoft.EntityFrameworkCore;
using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface IDiscountRepository : IGenericRepository<Discount>
    {
        Task<double> GetTotalDiscountAmount(int preInvoiceHeaderId);

        Task<double> GetFinalTotalDiscount(int customerId);

        Task<List<Discount>> GetAsyncWithPreInvoiceHeaderId(int preInvoiceHeaderId);

        Task<Discount> GetAsyncWithPreInvoiceDetailId(int preInvoiceDeatilId);

        Task<Discount> GetAsyncWithHeaderAndDetailIds(int preInvoiceHeaderId, int preInvoiceDeatilId);
    }
}

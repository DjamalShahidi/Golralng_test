using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface IDiscountRepository : IGenericRepository<Discount>
    {
        Task<double> GetTotalDiscount(int preInvoiceHeaderId);
    }
}

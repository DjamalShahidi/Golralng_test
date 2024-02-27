using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface IPreInvoiceDetailRepository : IGenericRepository<PreInvoiceDetail>
    {
        Task<bool> DublicateProduct(int preInvoiceHeaderId, int productId);

        Task<double> GetTotalPrice(int preInvoiceHeaderId);

        Task<double> GetFinalTotalPrice(int customerId);
    }
}

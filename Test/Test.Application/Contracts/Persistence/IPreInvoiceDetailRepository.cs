using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface IPreInvoiceDetailRepository : IGenericRepository<PreInvoiceDetail>
    {
        Task<bool> CheckDublicateProductForAdd(int preInvoiceHeaderId, int productId);

        Task<bool> CheckDublicateProductForUpdate(int preInvoiceHeaderId, int preInvoiceDetailId, int productId);
    
        Task<double> GetTotalPrice(int preInvoiceHeaderId);

        Task<double> GetFinalTotalPrice(int customerId);

        Task<bool> IsExistWithThisPreInvoiceHeaderId(int preInvoiceHeaderId);
    }
}

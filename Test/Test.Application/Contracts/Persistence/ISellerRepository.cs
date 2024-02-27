using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface ISellerRepository : IGenericRepository<Seller>
    {
        Task<bool> IsExist(int sellerId, int saleLineId);
    }
}

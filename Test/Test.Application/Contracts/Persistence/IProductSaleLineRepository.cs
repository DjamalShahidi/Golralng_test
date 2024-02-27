using Test.Domain;

namespace Test.Application.Contracts.Persistence
{
    public interface IProductSaleLineRepository : IGenericRepository<ProductSaleLine>
    {

        Task<bool> IsExist(int productId, int saleLineId);
    }
}

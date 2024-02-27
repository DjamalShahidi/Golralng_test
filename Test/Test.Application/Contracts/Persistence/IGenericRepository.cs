using System.Linq.Expressions;

namespace Test.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);

        Task<List<T>> GetListAsync();

        Task<T> GetAsync(int id);

        void Update(T entity);

        void Delete(T entity);

        Task<bool> IsExist(int id);

        Task<List<T>> GetListAsync(int from, int count);


        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter, int? from = null, int? to = null);
    }
}

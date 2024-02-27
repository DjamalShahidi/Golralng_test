using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Test.Application.Contracts.Persistence;

namespace Test.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TestDbContext _context;

        internal DbSet<T> dbSet;

        public GenericRepository(TestDbContext context)
        {
            this._context = context;
            dbSet = context.Set<T>();

        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetListAsync(int from,int count)
        {
            return await _context.Set<T>().Skip(from).Take(count).ToListAsync();
        }

        public async Task<bool> IsExist(int id)
        {
            var enity=await GetAsync(id);

            return enity != null;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }


        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter, int? from = null, int? to = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            query = query.Where(filter);

            if (from != null || to != null)
            {
                if (from == null)
                {
                    from = 0;
                }
                else if (to == null)
                {
                    to = 10;
                }

                query = query.Skip(from.Value).Take(to.Value);

            }

            return await query.ToListAsync();

        }
    }
}

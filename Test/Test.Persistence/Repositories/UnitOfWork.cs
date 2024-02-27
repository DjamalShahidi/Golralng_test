using Microsoft.EntityFrameworkCore.Storage;
using Test.Application.Contracts.Persistence;

namespace Test.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDbContext _context;

        //private IProductRepository _productRepository;



        public UnitOfWork(TestDbContext context)
        {
            this._context = context;
        }

        //public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);



        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(CancellationToken cancellationToken = default)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Database.BeginTransactionAsync(cancellationToken);
        }
    }
}

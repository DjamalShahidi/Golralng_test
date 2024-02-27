using Microsoft.EntityFrameworkCore.Storage;
using Test.Application.Contracts.Persistence;

namespace Test.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDbContext _context;

        public IDiscountRepository DiscountRepository => _dscountRepository ??= new DiscountRepository(_context);

        public IPreInvoiceHeaderRepository PreInvoiceHeaderRepository => _preInvoiceHeaderRepository ??= new PreInvoiceHeaderRepository(_context);

        public IPreInvoiceDetailRepository PreInvoiceDetailRepository => _preInvoiceDetailRepository ??= new PreInvoiceDetailRepository(_context);

        public ISaleLineRepository SaleLineRepository => _saleLineRepository ??= new SaleLineRepository(_context);

        public IProductRepository ProductRepository => _productRepository ??= new ProductRepository(_context);

        public IProductSaleLineRepository ProductSaleLineRepository => _productSaleLineRepository ??= new ProductSaleLineRepository(_context);

        private IDiscountRepository _dscountRepository;
        private IPreInvoiceHeaderRepository _preInvoiceHeaderRepository;
        private IPreInvoiceDetailRepository _preInvoiceDetailRepository;
        private ISaleLineRepository _saleLineRepository;
        private IProductRepository _productRepository;
        private IProductSaleLineRepository _productSaleLineRepository;


        public UnitOfWork(TestDbContext context)
        {
            this._context = context;
        }

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

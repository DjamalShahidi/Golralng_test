namespace Test.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IDiscountRepository DiscountRepository { get; }

        IPreInvoiceHeaderRepository PreInvoiceHeaderRepository { get; }

        IPreInvoiceDetailRepository PreInvoiceDetailRepository { get; }

        Task Save(CancellationToken cancellationToken);

        //Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    }
}

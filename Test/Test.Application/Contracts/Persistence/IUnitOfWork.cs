namespace Test.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        //ICategoryRepository CategoryRepository { get; }

        //IFeaturesRepository FeaturesRepository { get; }

        //ICategoryFeatureRepository CategoryFeatureRepository { get; }

        //IProductFeatureRepository ProductFeatureRepository { get; }

        //IUserRepository UserRepository { get; }

        //IProductRepository ProductRepository { get; }

        Task Save(CancellationToken cancellationToken);

        //Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
    }
}

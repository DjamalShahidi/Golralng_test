using Microsoft.EntityFrameworkCore;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class PreInvoiceHeaderRepository : GenericRepository<PreInvoiceHeader>, IPreInvoiceHeaderRepository
    {
        private readonly TestDbContext _context;

        public PreInvoiceHeaderRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}

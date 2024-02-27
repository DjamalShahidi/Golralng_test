using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class SellerRepository : GenericRepository<Seller>, ISellerRepository
    {
        private readonly TestDbContext _context;

        public SellerRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}

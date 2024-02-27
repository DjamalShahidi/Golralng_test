using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Domain;

namespace Test.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly TestDbContext _context;

        public CustomerRepository(TestDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Customer> GetAsyncByName(string firstName, string lastName)
        {
            return await _context.Customers.AsNoTracking().FirstOrDefaultAsync(a => a.FirstName == firstName && a.LastName==lastName);
        }

    }
}

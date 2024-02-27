using System.ComponentModel.DataAnnotations;
using Test.Domain.Common;

namespace Test.Domain
{
    public class Customer:BaseDomainEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PreInvoiceHeader> PreInvoiceHeaders { get; set; }
    }
}

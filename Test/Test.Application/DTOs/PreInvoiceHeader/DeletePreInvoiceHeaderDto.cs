using Test.Application.DTOs.Common;

namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record DeletePreInvoiceHeaderDto:BaseDto
    {
        public int PreInvoiceHeaderId { get; set; }
    }
}

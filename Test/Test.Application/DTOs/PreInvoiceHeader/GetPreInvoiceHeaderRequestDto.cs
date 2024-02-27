namespace Test.Application.DTOs.PreInvoiceHeader
{
    public record GetPreInvoiceHeaderRequestDto
    {
        public GetPreInvoiceHeaderRequestDto()
        {
            
        }
        public GetPreInvoiceHeaderRequestDto(int? id,int from,int to)
        {
            Id = id;
            From= from;
            To= to; 
        }
        public int? Id { get; set; }

        public int From { get; set; }

        public int To { get; set; }
    }
}

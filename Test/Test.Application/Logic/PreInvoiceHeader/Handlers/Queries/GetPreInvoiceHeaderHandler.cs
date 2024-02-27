using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System.Linq.Expressions;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;

namespace Test.Application.Logic.PreInvoiceHeader.Handlers.Queries
{
    public class GetPreInvoiceHeaderHandler : IRequestHandler<GetPreInvoiceHeader, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPreInvoiceHeaderHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetPreInvoiceHeader request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.Request.Id != null && request.Request.Id > 0)
                {
                    var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(request.Request.Id.Value);

                    var customer = await _unitOfWork.CustomerRepository.GetAsync(preInvoiceHeader.CustomerId);

                    var getPreInvoiceHeaderDto = _mapper.Map<GetPreInvoiceHeaderResponseDto>(preInvoiceHeader);

                    getPreInvoiceHeaderDto.Customer = _mapper.Map<GetPreInvoiceHeaderDtoCustomer>(customer);

                    return new Response()
                    {
                        IsSuccess = true,
                        Result = getPreInvoiceHeaderDto
                    };
                }
                else
                {

                    var preInvoiceHeaders = await _unitOfWork.PreInvoiceHeaderRepository.GetListAsync(request.Request.From, request.Request.To);

                    Expression<Func<Domain.Customer, bool>> filter = a => preInvoiceHeaders.Select(a => a.CustomerId).ToList().Contains(a.Id);


                    var customers = await _unitOfWork.CustomerRepository.GetListAsync(filter);

                    var result = new List<GetPreInvoiceHeaderResponseDto>();

                    foreach (var preInvoiceHeader in preInvoiceHeaders)
                    {
                        var getPreInvoiceHeaderDto = _mapper.Map<GetPreInvoiceHeaderResponseDto>(preInvoiceHeader);

                        var customerForThisHeadre = customers.FirstOrDefault(a => a.Id == preInvoiceHeader.CustomerId);

                        getPreInvoiceHeaderDto.Customer = _mapper.Map<GetPreInvoiceHeaderDtoCustomer>(customerForThisHeadre);

                        result.Add(getPreInvoiceHeaderDto);
                    }
                    return new Response()
                    {
                        IsSuccess = true,
                        Result = result
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    ErrorMessages = [ex.Message]
                };
            }
            
        }
    }
}

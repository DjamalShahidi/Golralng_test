using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System.Linq.Expressions;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;
using Test.Domain;

namespace Test.Application.Logic.PreInvoiceDetail.Handlers.Queries
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

            if (request.Id != null && request.Id > 0)
            {
                var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(request.Id.Value);

                var customer=await _unitOfWork.CustomerRepository.GetAsync(preInvoiceHeader.CustomerId);

                var getPreInvoiceHeaderDto = _mapper.Map<GetPreInvoiceHeaderDto>(preInvoiceHeader);

                getPreInvoiceHeaderDto.Customer= _mapper.Map<GetPreInvoiceHeaderDtoCustomer>(customer);

                return new Response()
                {
                    IsSuccess = true,
                    Result = getPreInvoiceHeaderDto
                };
            }
            else
            {

                var preInvoiceHeaders = await _unitOfWork.PreInvoiceHeaderRepository.GetListAsync(request.From,request.To);

                Expression<Func<Domain.Customer, bool>> filter = a => preInvoiceHeaders.Select(a => a.CustomerId).ToList().Contains(a.Id);


                var customers = await _unitOfWork.CustomerRepository.GetListAsync(filter);

                var result = new List<GetPreInvoiceHeaderDto>();

                foreach (var preInvoiceHeader in preInvoiceHeaders)
                {
                    var getPreInvoiceHeaderDto = _mapper.Map<GetPreInvoiceHeaderDto>(preInvoiceHeader);

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
    }
}

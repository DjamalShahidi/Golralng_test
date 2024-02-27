using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System.Linq.Expressions;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.Discount;
using Test.Application.DTOs.PreInvoiceHeader;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;
using Test.Domain;

namespace Test.Application.Logic.PreInvoiceDetail.Handlers.Queries
{
    public class GetDiscountHandler : IRequestHandler<GetDiscount, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetDiscountHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetDiscount request, CancellationToken cancellationToken)
        {
            if (request.PreInvoiceHeaderId!=null && request.PreInvoiceDetailId!=null)
            {
                var discount = await _unitOfWork.DiscountRepository.GetAsyncWithHeaderAndDetailIds(request.PreInvoiceHeaderId.Value, request.PreInvoiceDetailId.Value);

                var result = _mapper.Map<GetDiscountDto>(discount);

                return new Response()
                {
                    IsSuccess = true,
                    Result = result
                };
            }
           else if (request.PreInvoiceHeaderId!=null )
            {
                var discounts = await _unitOfWork.DiscountRepository.GetAsyncWithPreInvoiceHeaderId(request.PreInvoiceHeaderId.Value);

                var result = _mapper.Map<GetDiscountDto>(discounts);

                return new Response()
                {
                    IsSuccess = true,
                    Result = result
                };
            }
            else if (request.PreInvoiceDetailId!=null)
            {
                var discount = await _unitOfWork.DiscountRepository.GetAsyncWithPreInvoiceDetailId(request.PreInvoiceDetailId.Value);

                var result = _mapper.Map<GetDiscountDto>(discount);

                return new Response()
                {
                    IsSuccess = true,
                    Result = result
                };
            }
            return new Response()
            {
                IsSuccess = false,
                Result = null
            };
        }
    }
}

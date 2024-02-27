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
            try
            {

                if (request.Request.PreInvoiceHeaderId != null && request.Request.PreInvoiceDetailId != null)
                {
                    var discount = await _unitOfWork.DiscountRepository.GetAsyncWithHeaderAndDetailIds(request.Request.PreInvoiceHeaderId.Value, request.Request.PreInvoiceDetailId.Value);

                    var result = _mapper.Map<GetDiscountResponseDto>(discount);

                    return new Response()
                    {
                        IsSuccess = true,
                        Result = result
                    };
                }
                else if (request.Request.PreInvoiceHeaderId != null)
                {
                    var discounts = await _unitOfWork.DiscountRepository.GetAsyncWithPreInvoiceHeaderId(request.Request.PreInvoiceHeaderId.Value);

                    var result = _mapper.Map<List<GetDiscountResponseDto>>(discounts);

                    return new Response()
                    {
                        IsSuccess = true,
                        Result = result
                    };
                }
                else if (request.Request.PreInvoiceDetailId != null)
                {
                    var discount = await _unitOfWork.DiscountRepository.GetAsyncWithPreInvoiceDetailId(request.Request.PreInvoiceDetailId.Value);

                    var result = _mapper.Map<GetDiscountResponseDto>(discount);

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

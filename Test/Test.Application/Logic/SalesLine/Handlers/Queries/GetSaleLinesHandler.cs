using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System.Collections.Generic;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.SalesLine;
using Test.Application.Logic.SalesLine.Requests.Queries;

namespace Test.Application.Logic.SalesLine.Handlers.Queries
{
    public class GetSaleLinesHandler : IRequestHandler<GetSaleLines, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSaleLinesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetSaleLines request, CancellationToken cancellationToken)
        {
            try
            {
                var saleLines = await _unitOfWork.SaleLineRepository.GetListAsync();

                var products = await _unitOfWork.ProductRepository.GetListAsync();

                var productSaleLines = await _unitOfWork.ProductSaleLineRepository.GetListAsync();

                var sellers = await _unitOfWork.SellerRepository.GetListAsync();

                var list = new List<GetSaleLineDto>();

                foreach (var saleLine in saleLines)
                {
                    var productIdsForThisLines = productSaleLines.Where(a => a.SalesLine == saleLine).Select(a => a.ProductId).ToList();

                    var productsForThisLines = products.Where(a => productIdsForThisLines.Contains(a.Id)).ToList();

                    var sellersForThisLines = sellers.Where(a => a.SalesLine == saleLine).ToList();

                    list.Add(new GetSaleLineDto()
                    {
                        Id = saleLine.Id,
                        Title = saleLine.Title,
                        Products = _mapper.Map<List<GetSaleLineDtoProduct>>(productsForThisLines),
                        Sellers = _mapper.Map<List<GetSaleLineSeller>>(sellersForThisLines)
                    });
                }

                return new Response()
                {
                    IsSuccess = true,
                    Result = list
                };
            }
            catch (Exception ex)
            {
                return new Response()
                {
                    IsSuccess = false,
                    ErrorMessages = new List<string> { ex.Message }
                };
            }
            
        }
    }


}

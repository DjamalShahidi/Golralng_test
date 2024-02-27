using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System.Linq.Expressions;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceDetail;
using Test.Application.Logic.PreInvoiceHeader.Requests.Queries;

namespace Test.Application.Logic.PreInvoiceDetail.Handlers.Queries
{
    public class GetPreInvoiceDetailHandler : IRequestHandler<GetPreInvoiceDetail, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetPreInvoiceDetailHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(GetPreInvoiceDetail request, CancellationToken cancellationToken)
        {
            Expression<Func<Domain.PreInvoiceDetail, bool>> filter = a => request.PreInvoiceHeaderId == a.PreInvoiceHeaderId;

            var preInvoiceDetais = await _unitOfWork.PreInvoiceDetailRepository.GetListAsync(filter);

            var productIds = preInvoiceDetais.Select(a => a.ProductId).ToList();

            Expression<Func<Domain.Product, bool>> productFilter = a => productIds.Contains(a.Id);

            var products = await _unitOfWork.ProductRepository.GetListAsync(productFilter);

            var result = new List<GetPreInvoiceDetailDto>();

            foreach (var item in preInvoiceDetais)
            {
                var getPreInvoiceDetailDto = _mapper.Map<GetPreInvoiceDetailDto>(item);

                var productForThisDetails = products.FirstOrDefault(a => a.Id == item.ProductId);

                getPreInvoiceDetailDto.Product = _mapper.Map<GetPreInvoiceDetailDtoProduct>(productForThisDetails);

                result.Add(getPreInvoiceDetailDto); 
            }

            return new Response()
            {
                IsSuccess = true,
                Result = result
            };
        }
    }
}

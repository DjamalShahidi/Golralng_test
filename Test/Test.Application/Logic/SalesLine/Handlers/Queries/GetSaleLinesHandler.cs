using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader._ٰValidator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Application.Logic.SalesLine.Requests.Queries;
using Test.Domain;

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
            //var saleLines = await _unitOfWork.PreInvoiceHeaderRepository.AddAsync(preInvoiceHeader);

            return new Response()
            {
                IsSuccess = true,
            };
        }
    }


}

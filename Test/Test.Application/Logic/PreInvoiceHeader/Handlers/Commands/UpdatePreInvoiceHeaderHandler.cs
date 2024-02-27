using AutoMapper;
using MediatR;
using Store.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.PreInvoiceHeader.Validator;
using Test.Application.Logic.PreInvoiceHeader.Requests.Commands;
using Test.Domain;

namespace Test.Application.Logic.PreInvoiceHeader.Handlers.Commands
{
    public class UpdatePreInvoiceHeaderHandler : IRequestHandler<UpdatePreInvoiceHeader, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdatePreInvoiceHeaderHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(UpdatePreInvoiceHeader request, CancellationToken cancellationToken)
        {
            var validator = new UpdatePreInvoiceHeaderDtoValidator(_unitOfWork);

            var validatorResult = await validator.ValidateAsync(request.Request);

            if (validatorResult.IsValid == false)
            {
                return new Response()
                {
                    ErrorMessages = validatorResult.Errors.Select(a => a.ErrorMessage).ToList(),
                    IsSuccess = false,
                    Result = null
                };
            }

            var preInvoiceHeader = await _unitOfWork.PreInvoiceHeaderRepository.GetAsync(request.Request.Id);

            preInvoiceHeader.SellerId = request.Request.SellerId;

            preInvoiceHeader.SalesLineId= request.Request.SalesLineId;

            var customer = _mapper.Map<Domain.Customer>(request.Request.Customer);

            var dbCusomer = await _unitOfWork.CustomerRepository.GetAsyncByName(customer.FirstName, customer.LastName);

            using (var transaction = await _unitOfWork.BeginTransactionAsync(cancellationToken))
            {
                try
                {
                    if (dbCusomer != null)
                    {
                        preInvoiceHeader.CustomerId = dbCusomer.Id;
                    }
                    else
                    {
                        await _unitOfWork.CustomerRepository.AddAsync(customer);

                        await _unitOfWork.Save(cancellationToken);

                        preInvoiceHeader.CustomerId = customer.Id;
                    }
                    
                    _unitOfWork.PreInvoiceHeaderRepository.Update(preInvoiceHeader);

                    await _unitOfWork.Save(cancellationToken);

                    await transaction.CommitAsync(cancellationToken);

                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync(cancellationToken);
                    return new Response()
                    {
                        IsSuccess = false,
                        ErrorMessages = new List<string> { ex.Message }
                    };
                }
            }

            return new Response()
            {
                IsSuccess = true
            };
        }

    }
}

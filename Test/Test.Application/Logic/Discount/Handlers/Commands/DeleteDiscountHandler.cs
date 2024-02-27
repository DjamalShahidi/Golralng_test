using AutoMapper;
using MediatR;
using Store.Application.Responses;
using Test.Application.Contracts.Persistence;
using Test.Application.DTOs.Discount.Validator;
using Test.Application.Logic.Discount.Requests.Commands;

namespace Test.Application.Logic.Discount.Handlers.Commands
{
    public class DeleteDiscountHandler : IRequestHandler<DeleteDiscount, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteDiscountHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response> Handle(DeleteDiscount request, CancellationToken cancellationToken)
        {
            var validator = new DeleteDiscountDtoValidator(_unitOfWork);

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

            var discount = await _unitOfWork.DiscountRepository.GetAsync(request.Request.Id);

            _unitOfWork.DiscountRepository.Delete(discount);

            await _unitOfWork.Save(cancellationToken);

            return new Response()
            {
                IsSuccess = true,
            };
        }

    }
}

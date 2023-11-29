using Entities.Models.Members;
using FluentValidation;
using Mapster;
using MediatR;
using Telecare.Domain.UnitofWork;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IApplicationUnitofWork unitOfWork;
        private readonly IValidator<RegisterUserCommand> validator;

        public RegisterCommandHandler(IApplicationUnitofWork unitOfWork, IValidator<RegisterUserCommand> validator)
        {
            this.unitOfWork = unitOfWork;
            this.validator = validator;
        }

        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var user = request.memberDto.Adapt<Member>();

            await unitOfWork.MemberRepositrory.IsertAsync(user);
            var result = await unitOfWork.SavChangeAsync(cancellationToken);

            if (result)
            {

            }
            unitOfWork.Dispose();
        }
    }
}

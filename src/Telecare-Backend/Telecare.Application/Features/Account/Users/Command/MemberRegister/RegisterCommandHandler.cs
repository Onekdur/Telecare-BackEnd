using Entities.Models.Members;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Telecare.Domain.UnitofWork;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IValidator<RegisterUserCommand> validator;

        public RegisterCommandHandler(IUnitOfWork unitOfWork, IValidator<RegisterUserCommand> validator)
        {
            this.unitOfWork = unitOfWork;
            this.validator = validator;
        }

        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var validateResult = await validator.ValidateAsync(request, cancellationToken);

            var user = request.memberDto.Adapt<Member>();

            await unitOfWork.MemberRepositrory.IsertAsync(user);
            var result = await unitOfWork.SavChangeAsync(cancellationToken);

            if(result)
            {

            }
            unitOfWork.Dispose();
        }
    }
}

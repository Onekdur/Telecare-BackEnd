using Entities.Models.Members;
using Mapster;
using MediatR;
using Telecare.Domain.UnitofWork;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : IRequestHandler<RegisterUserCommand>
    {
        private readonly IUnitOfWork unitOfWork;

        public RegisterCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.memberDto.Adapt<Member>();

            await unitOfWork.MemberRepositrory.IsertAsync(user);
            await unitOfWork.SavChangeAsync(cancellationToken);
            unitOfWork.Dispose();
        }
    }
}

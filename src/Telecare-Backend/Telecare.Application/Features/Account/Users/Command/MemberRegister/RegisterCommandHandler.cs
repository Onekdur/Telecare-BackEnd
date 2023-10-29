using Mapster;
using MediatR;
using Telecare.Application.DTOs;
using Telecare.Domain.UnitofWork;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : IRequestHandler<RegisterUserCommand,MemberDTO>
    {
        private readonly IUnitOfWork unitOfWork;

        public RegisterCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public Task<MemberDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.Adapt<>
        }
    }
}

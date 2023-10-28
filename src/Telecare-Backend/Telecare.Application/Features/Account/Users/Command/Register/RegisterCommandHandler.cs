using Mapster;
using Telecare.Application.Abstraction.Messaging;
using Telecare.Application.Contracts;
using Telecare.Application.DTOs;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : ICommandHandler<RegisterUserCommand, RegisterCommandResponse>
    {
        private readonly IIdentityService identityService;

        public RegisterCommandHandler(IIdentityService identityService)
        {
            this.identityService = identityService;
        }

        public Task<IResult<RegisterCommandResponse>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var result = identityService.CreateUserAsync(request.Adapt<RegisterUserDTO>(), cancellationToken);
        }
    }
}

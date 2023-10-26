using Telecare.Application.Abstraction.Messaging;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed class RegisterCommandHandler : ICommandHandler<RegisterUserCommand, RegisterCommandResponse>
    {
        public Task<IResult<RegisterCommandResponse>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

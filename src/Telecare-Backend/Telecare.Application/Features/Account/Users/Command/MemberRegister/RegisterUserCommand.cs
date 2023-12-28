using MediatR;
using Telecare.Application.DTOs;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed record RegisterUserCommand(MemberDTO memberDto) : IRequest
    {

    }
}

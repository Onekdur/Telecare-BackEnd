using MediatR;
using Telecare.Application.DTOs;
using Telecare.Domain.Enum;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed record RegisterUserCommand(MemberDTO memberDto) : IRequest
    {

    }
}

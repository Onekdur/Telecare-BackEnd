using MediatR;
using Telecare.Application.DTOs;
using Telecare.Domain.Enum;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed record RegisterUserCommand(string FirstName, string LastName, string Email,
        string Password, Gender GenDer, DateTime BirthDate) : IRequest<MemberDTO>
    {

    }
}

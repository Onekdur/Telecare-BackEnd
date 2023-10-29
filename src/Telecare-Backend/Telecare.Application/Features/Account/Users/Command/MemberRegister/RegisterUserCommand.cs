using MediatR;
using Telecare.Application.DTOs;
using Telecare.Domain.Enum;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed record RegisterUserCommand(string firstName, string lastName, string emailorPhone,
        string password, Gender gender, DateTime birthDate) : IRequest<MemberDTO>
    {

    }
}

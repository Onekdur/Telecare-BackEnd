using Telecare.Domain.Enum;

namespace Telecare.Application.DTOs
{
    public sealed record MemberDTO(string FirstName, string LastName, string Email,
        string Password, Gender GenDer, DateTime BirthDate);
}

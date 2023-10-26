using Telecare.Domain.Enum;

namespace Telecare.Application.DTOs
{
    public sealed record RegisterUserDTO(string firstName, string lastName, string email,
        string password, Gender gender, DateTime birthDate);
}

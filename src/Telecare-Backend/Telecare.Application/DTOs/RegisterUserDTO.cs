using Telecare.Domain.Enum;

namespace Telecare.Application.DTOs
{
    public sealed record RegisterUserDTO(string firstName, string lastName, string emailorPhone,
        string password, Gender gender, DateTime birthDate);
}

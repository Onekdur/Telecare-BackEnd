using Telecare.Domain.Enum;

namespace Telecare.Application.Features.Account.Users.Command.Register
{
    public sealed record RegisterCommandResponse
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}

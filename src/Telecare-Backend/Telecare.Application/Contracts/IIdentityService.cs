using Telecare.Application.DTOs;
using Telecare.Domain.Enum;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Contracts
{
    public interface IIdentityService
    {
        Task<IResult<Guid>> CreateUserAsync(RegisterUserDTO registerUserDTO, CancellationToken token);
    }
}

using MediatR;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Abstraction.Messaging
{
    public interface IQuery<out TResponse> : IRequest<IResult<TResponse>>
        where TResponse : class
    {

    }
}

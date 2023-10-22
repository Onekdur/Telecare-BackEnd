using MediatR;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Abstraction.Messaging
{
    public interface ICommand : IRequest<IResult>
    {
    }

    public interface ICommand<out TResponse> : IRequest<IResult<TResponse>>
        where TResponse : class
    {
    }
}

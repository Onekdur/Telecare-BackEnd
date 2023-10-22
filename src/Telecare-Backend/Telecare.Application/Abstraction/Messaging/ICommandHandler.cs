using MediatR;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Abstraction.Messaging
{
    public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest,IResult>
        where TRequest : ICommand
    {
    }

    public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, IResult<TResponse>>
        where TRequest : ICommand<TResponse>
        where TResponse : class
    {
    }
}

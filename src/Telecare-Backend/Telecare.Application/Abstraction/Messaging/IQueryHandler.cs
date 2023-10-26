using MediatR;
using Telecare.InfraSturecture.Model.Abstract;

namespace Telecare.Application.Abstraction.Messaging
{
    public interface IQueryHandler<in TRequest,TResponse> : IRequestHandler<TRequest, IResult<TResponse>>
        where TRequest : IQuery<TResponse>
        where TResponse : class
    {
    }
}

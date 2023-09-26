using Entities.Models.Member;
using Microsoft.EntityFrameworkCore;

namespace Telecare.Application.Contract
{
    public interface IApplicationDbContext: IDisposable,IAsyncDisposable
    {
        DbSet<Member> members { get; }
        DbSet<TEntity> DbSet<TEntity>() where TEntity : class;        
    }
}

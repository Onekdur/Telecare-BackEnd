using Entities.Models.Member;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telecare.Application.Contract;

namespace Telecare.Persistance.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<Member>, IApplicationDbContext
    {
        public ApplicationDbContext()
        {
            
        }

        public DbSet<Member> members => Set<Member>();

        public DbSet<TEntity> DbSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}

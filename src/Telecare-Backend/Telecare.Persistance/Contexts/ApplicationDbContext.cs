using Entities.Models.Member;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telecare.Application.Contract;
using Telecare.Persistance.Contexts.Configuration;

namespace Telecare.Persistance.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<Member>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MemberConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Member> members { get; set; }

    }
}

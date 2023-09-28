using Entities.Models.Member;
using Microsoft.EntityFrameworkCore;

namespace Telecare.Application.Contract
{
    public interface IApplicationDbContext: IDisposable,IAsyncDisposable
    {
        DbSet<Member> Members { get; set; }
        public DbSet<CoverPhoto> CoverPhotos { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}

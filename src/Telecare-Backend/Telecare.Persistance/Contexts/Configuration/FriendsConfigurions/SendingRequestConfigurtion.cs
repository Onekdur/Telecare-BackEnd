using Entities.Models.Friends;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.FriendsConfigurions
{
    public class SendingRequestConfigurtion : IEntityTypeConfiguration<SendingRequest>
    {
        public void Configure(EntityTypeBuilder<SendingRequest> builder)
        {
            builder.HasData(new SendingRequest()
            {
                Id = Guid.NewGuid(),
                SendFriendRequestId = Guid.NewGuid(),
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}

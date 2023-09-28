using Entities.Models.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(new Address()
            {
                AddressID = Guid.NewGuid(),
                ParmanentAdress = "Pabna",
                PresentAddress = "Kushtia",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Member
{
    public class Address
    {
        [Key]
        public Guid AddressID { get; set; }
        public Guid PresentAddress { get; set; }
        public Guid ParmanentAdress { get; set; }
        public Member Member { get; set; }
    }
}

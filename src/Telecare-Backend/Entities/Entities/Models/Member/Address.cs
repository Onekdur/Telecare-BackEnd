using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Member
{
    public class Address
    {
        [Key]
        public Guid AddressID { get; set; }
        public string PresentAddress { get; set; }
        public string ParmanentAdress { get; set; }
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}

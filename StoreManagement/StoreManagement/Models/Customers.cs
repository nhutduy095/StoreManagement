using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Customers : BaseModel
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCd { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [NotMapped]
        public string PassWord { get; set; }
        public virtual ICollection<Carts> Carts { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}

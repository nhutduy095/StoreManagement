using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class CartDetails:BaseModel
    {
        public int CartDtlId { get; set; }
        public int CartId { get; set; }
        public int ItemId { get; set; }
        [NotMapped]
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

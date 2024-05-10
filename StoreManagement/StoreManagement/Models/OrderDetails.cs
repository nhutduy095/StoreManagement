namespace StoreManagement.Models
{
    public class OrderDetails:BaseModel
    {
        public int OrderDtlId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}

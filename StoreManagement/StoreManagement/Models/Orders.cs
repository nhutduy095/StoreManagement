namespace StoreManagement.Models
{
    public class Orders:BaseModel
    {
        public int OrderId { get; set; }
        public int GuestId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentMethod { get; set; }
    }
}

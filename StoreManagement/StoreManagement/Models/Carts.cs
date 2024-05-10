namespace StoreManagement.Models
{
    public class Carts:BaseModel
    {
        public int CartId { get; set; }
        public int GuestId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCd { get; set; }
        public string CustomerName { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
        public decimal TotalMoney { get; set; }
    }
}

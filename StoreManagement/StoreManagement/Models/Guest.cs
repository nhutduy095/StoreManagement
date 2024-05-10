namespace StoreManagement.Models
{
    public class Guest:BaseModel
    {
        public int GuestId { get; set; }
        public string GuestLastName { get; set; }
        public string GuestFirsttName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}

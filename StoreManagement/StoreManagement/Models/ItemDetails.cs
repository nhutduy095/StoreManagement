namespace StoreManagement.Models
{
    public class ItemDetails:BaseModel
    {
        public int ItemDtId { get; set; }
        public int ItemId { get; set; }
        //public string Chip { get; set; }
        //public string Ram { get; set; }
        //public string Screen { get; set; }
        //public string Memory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

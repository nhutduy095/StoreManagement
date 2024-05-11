namespace StoreManagement.Models
{
    public class ItemImage:BaseModel
    {
        public int ImageId { get; set; }
        public string ImageURL { get; set; }
        public bool ImageBackground { get; set; }
        public int ItemId { get; set; }
    }
}

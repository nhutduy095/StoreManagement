namespace StoreManagement.Models
{
    public class ItemMenuDetail : BaseModel
    {
        public int Id { get; set; }
        public int ItemMenuId {  get; set; }
        public int ItemId {  get; set; }
    }
}

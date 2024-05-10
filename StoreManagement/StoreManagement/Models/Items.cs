using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManagement.Models
{
    public class Items:BaseModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public DateTime StartDate { get; set; }
        [NotMapped]
        public DateTime EndDate { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public string CategoryName { get; set; }
        [NotMapped]
        public string UrlImg { get; set; }
    }
}

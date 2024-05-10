namespace StoreManagement.Models
{
    public class Combos:BaseModel
    {
        public int ComboId { get; set; }
        public string ComboName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Items> Items { get; set; } //những sp trong combo
    }
}

namespace CrunchyGranola.Models
{
    public class Product
    {
        public int UpcCode { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string LeadTimes { get; set; }

        public virtual Department Department { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
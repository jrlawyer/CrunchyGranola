namespace CrunchyGranola.Models
{
    public class Product 
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int DepartmentID { get; set; }
        public int UpcCode { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string LeadTimes { get; set; }

        public virtual Department Department { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
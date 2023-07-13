namespace E_Commerce.Models
{
    public class Supplier
    {
        public int  SupplierID { get; set; }
        public string ContactFName {get;set;}
        public string ContactLName {get;set;}
        public string ContactTitle {get;set;}
        public virtual ICollection<Product> Products { get; set; }
    }
}

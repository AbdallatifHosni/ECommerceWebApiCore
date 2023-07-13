namespace E_Commerce.Models
{
    public class Customer
    {
       public int CustomerID { get; set; }
       public string FirstName  {get;set;}
       public string LastName   {get;set;}
       public string ContactName{get;set;}
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }

    }
}

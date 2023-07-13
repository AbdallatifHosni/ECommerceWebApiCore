using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Cart
    {

        public int CartId { get; set; }
        public decimal TotalPrice { get; set; }
        public int NumOfProducts { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
    }
}

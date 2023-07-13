using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class OrderDetails
    {

        public int OrderDetailsID{ get; set; }
        public int  Quantity { get; set; }
        public decimal UnitPrice  {get;set;}
        public float Discount   {get;set;}
        public int  OrderNumber{get;set;}
        public int OrderId { get;set;}
        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set;}
        public int  ProductId { get; set; }
    }
}

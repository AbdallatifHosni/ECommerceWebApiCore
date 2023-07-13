using E_Commerce.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.DTO
{
    public class OrderDetailsDto
    {
        public int OrderDetailsID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public int OrderNumber { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace E_Commerce.DTO
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string RequiredData { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipperID { get; set; }
        public string Freight { get; set; }
        public int CustomerID { get; set; }
    }
}

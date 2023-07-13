using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int  OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string RequiredData { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipperID { get; set; }
        public string Freight { get; set; }

        public int  CustomerID { get; set; }
        
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }


    }
}

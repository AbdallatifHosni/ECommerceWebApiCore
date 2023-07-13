using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

namespace E_Commerce.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Address { get; set; }
        public string QuantityPerUnit { get; set; }
        public string ProductDescription { get; set; }
        public string ReorderLevel { get; set; }
        public byte[] Picture { get; set; }
        public decimal Discount { get; set; }
        public string UnitWeight { get; set; }
        public int UnitsOnOrder { get; set; }
        public string UnitPrice { get; set; }
        public int SupplierID { get; set; }
        public int CategoryId {get;set;}

        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set;}
        public virtual ICollection<Supplier> Suppliers { get; set; }

    }
}

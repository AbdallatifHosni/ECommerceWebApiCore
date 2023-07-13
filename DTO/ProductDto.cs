namespace E_Commerce.DTO
{
    public class ProductDto
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
        public int CategoryId { get; set; }
    }
}

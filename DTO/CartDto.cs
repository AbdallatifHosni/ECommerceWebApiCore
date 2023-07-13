namespace E_Commerce.DTO
{
    public class CartDto
    {
        public int CartId { get; set; }
        public decimal TotalPrice { get; set; }
        public int NumOfProducts { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}

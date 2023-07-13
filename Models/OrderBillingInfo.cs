namespace E_Commerce.Models
{
    public class OrderBillingInfo
    {
        public int OrderId { get; set; }
        public int BillingInfoId { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}

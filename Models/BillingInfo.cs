using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class BillingInfo
    {
        [Key]
     public int BillingInfoID { get; set; }
     public DateTime  CreditCardEXPdate  { get; set; }
     public int   CreditCardPIN  { get; set; }
     public long  CreditCardNo   { get; set; }
     public DateTime   BillDate       { get; set; }
     public long      CreditCardID   { get; set; }
     public string BillingAddress { get; set; }
    
    }
}

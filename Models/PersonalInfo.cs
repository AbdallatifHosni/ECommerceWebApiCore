using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace E_Commerce.Models
{
    public class PersonalInfo
    {
        [Key]
        public int PersonalInfoID { get; set; }
        public string Phone {get;set;}
        public string Email  {get;set;}
        public string Address { get; set; }
        public string Country { get; set; }
        public string City {get;set;}
        public string PostalCode  {get;set;}
             

    }
}

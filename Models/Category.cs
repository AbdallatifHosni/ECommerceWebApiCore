﻿namespace E_Commerce.Models
{
    public class Category
    {
        public int  CategoryID { get; set; }
        public string Name  {get;set;}
        public string Description   {get;set;}
        public byte[] Picture       {get;set;}
        public virtual ICollection<Product> Products { get; set; }
    }
}

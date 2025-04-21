using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechFix
{
    public class ProductRequest
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }

        public ProductRequest(string productId, string productName, int quantity, double totalPrice)
        {
            this.ProductID = productId;
            this.ProductName = productName;
            this.Quantity = quantity;
            this.TotalPrice = totalPrice;
        }
    }
}
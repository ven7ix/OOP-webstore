using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_webstore
{
    internal class ProductFood : IProduct
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ProductFood(int price, int quantity, int productID, DateTime expirationDate)
        {
            Price = price;
            Quantity = quantity;
            ProductID = productID;
            ExpirationDate = expirationDate;
        }
    }
}
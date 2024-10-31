using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_webstore
{
    internal class ProductElectronics<T> : IProduct<T>
    {
        public T Price { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public string ElectronicsType { get; set; }

        public ProductElectronics(T price, int quantity, int productID, string electronicsType)
        {
            Price = price;
            Quantity = quantity;
            ProductID = productID;
            ElectronicsType = electronicsType;
        }

        public ProductElectronics(ProductElectronics<T> electronics)
        {
            Price = electronics.Price;
            Quantity = electronics.Quantity;
            ProductID = electronics.ProductID;
            ElectronicsType = electronics.ElectronicsType;
        }
    }
}

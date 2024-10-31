using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_webstore
{
    public interface IProduct<T>
    {
        T Price { get; }
        int Quantity { get; set; }
        int ProductID { get; }
    }
}

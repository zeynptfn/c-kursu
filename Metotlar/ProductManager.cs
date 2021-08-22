using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class ProductManager
    {
        public void Add( Product product) 
        {
            Console.WriteLine(product.ProductName + "eklendi");
        }
        public int Topla (int a, int b)
        {
            return a + b;

        }
    }
}

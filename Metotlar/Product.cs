using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double  UnitPrice { get; set; }
        public int UnitsInStocks { get; set; }
    }
}

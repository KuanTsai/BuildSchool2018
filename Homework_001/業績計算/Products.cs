using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 業績計算
{
    class Products
    {
        public string Product { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int SUM2
        {
            get { return Price * Quantity; }
        }
    }
}

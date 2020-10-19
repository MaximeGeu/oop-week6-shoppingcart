using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Till
    {
        public double Total { get; set; }

        public double Sum(List<Product> list)
        {
            double total = 0;

            for (int i = 0; i < list.Count(); i++)
            {
                total = total + list[i].Price;
            }
            Total = total;

            return total;
        }
    }
}

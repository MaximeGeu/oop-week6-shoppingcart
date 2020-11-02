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

        public double Discount(List<Product> product)
        {
            double total = Sum(product);

            int countApple = 0;
            int countOrange = 0;

            double discount = 0;

            foreach(Product item in product)
            {
                if(item.Name=="Apple")
                {
                    countApple++;
                    if(countApple%2==0 && countApple>0)
                    {
                        discount = discount - item.Price;
                    }
                }
                else if(item.Name=="Orange")
                {
                    countOrange++;
                    if (countOrange % 3 == 0 && countOrange > 0)
                    {
                        discount = discount - item.Price;
                    }
                }
            }

            Total = total + discount;

            return Total;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class ProductPrice
{
        public static decimal getProductPrice(char product)
        {
            decimal price = 0;
            switch (product)
            {
                case 'A':
                    price = 50;
                    break;
                case 'B':
                    price = 30;
                    break;
                case 'C':
                    price = 20;
                    break;
                case 'D':
                    price = 15;
                    break;
            }
            return price;
        }
    }
}

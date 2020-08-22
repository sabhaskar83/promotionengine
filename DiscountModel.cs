using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class DiscountModel : IDiscountModel
    {
        public decimal ApromotionEngine(List<string> cart)
        {
            decimal totalprice = 0;
            var countA = (from a in cart
                          where a.ToUpper() == "A"
                          select a).Count();
            var countB = (from a in cart
                          where a.ToUpper() == "B"
                          select a).Count();
            var countC = (from a in cart
                          where a.ToUpper() == "C"
                          select a).Count();
            var countD = (from a in cart
                          where a.ToUpper() == "D"
                          select a).Count();

            decimal priceA = 0;
            decimal priceB = 0;
            priceA = ((int)countA / 3) * 130 + (countA % 3 * ProductPrice.getProductPrice('A'));
            priceB = ((int)countB / 2) * 45 + (countB % 2 * ProductPrice.getProductPrice('B'));
            if (countC == countD)
                totalprice = priceA + priceB + (countC * 30);
            else if (countC > countD)
                totalprice = ((countC - countD) * ProductPrice.getProductPrice('C')) +
                               (countD * 30) + priceA + priceB;
            else
                totalprice = ((countD - countC) * ProductPrice.getProductPrice('D')) +
                               (countC * 30) + priceA + priceB;


            return totalprice;

        }

    }
}

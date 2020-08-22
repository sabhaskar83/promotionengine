using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public interface IDiscountModel
    {
        decimal ApromotionEngine(List<string> cart);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    class Program
{
       
    static void Main(string[] args)
    {
            try
            {
                
                string[] iparray = args[0].Split(',');
                IDiscountModel dicountmodel = new DiscountModel();
                List<string> cart = new List<string>();
                cart.AddRange(iparray);
                decimal tp = dicountmodel.ApromotionEngine(cart);
                Console.WriteLine("totalprice:" + tp);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
    }
}
  
    
   
}

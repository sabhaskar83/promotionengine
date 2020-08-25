using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public class Tests
    {
        private PromotionEngine.DiscountModel ds;
        [SetUp]
        public void Setup()
        {
            ds = new PromotionEngine.DiscountModel();
        }

        [Test]
        public void Test1()
        {
            //Scenario A-a,b,c
            List<string> sku = new List<string>()
            {
                "a","b","c"
            };

            decimal res = ds.ApromotionEngine(sku);
            Assert.IsTrue(res==100,$"Total order value is {res}",sku);
            Console.WriteLine($"Total order value is {res}");
           
        }

        [Test]
        public void Test2()
        {
            //Scenario B- 5a,5b,c
            List<string> sku = new List<string>()
            {
                "a","a","a","a","a","b","b","b","b","b","c"
            };

            decimal res = ds.ApromotionEngine(sku);
            Assert.IsTrue(res == 370, $"Total order value is {res}", sku);
            Console.WriteLine($"Total order value is {res}");
            
        }

        [Test]
        public void Test3()
        {
            //Scenario C- 3a,5b,c,d
            List<string> sku = new List<string>()
            {
                "a","a","a","b","b","b","b","b","c","d"
            };

            decimal res = ds.ApromotionEngine(sku);
            Assert.IsTrue(res == 280, $"Total order value is {res}", sku);
            Console.WriteLine($"Total order value is {res}");
            
        }


    }
}
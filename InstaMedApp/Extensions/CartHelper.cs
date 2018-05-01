using System;
using System.Collections.Generic;
using System.Linq;
using InstaMedData.Models;
using System.Threading.Tasks;

namespace InstaMedApp.Extensions
{
    public static class CartHelper
    {
        private static List<Test> cart;
        private static List<Temp> testsId;
        static CartHelper()
        {
            cart = new List<Test>();
            testsId = new List<Temp>();
        }
        public static void AddToCart(Test newTest)
        {
            testsId.Add(new Temp(newTest.Id));
            cart.Add(newTest);
        }
        public static void ResetCart()
        {
            testsId.Clear();
            cart.Clear();
        }
        public static List<Temp> GetCart()
        {
            return testsId;
        }
    }
}

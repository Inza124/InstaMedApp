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
        private static bool isBreak;
        private static int VisitId;
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

        public static void SetVisitId(int id)
        {
            VisitId = id;
        }

        public static int GetVisitId()
        {
            return VisitId;
        }

        public static void ResetVisitId()
        {
            VisitId = 0;
        }

        public static void SetBreak()
        {
            isBreak = true;
        }

        public static bool GetBreak()
        {
            return isBreak;
        }
    }
}

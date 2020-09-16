using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebSiteGate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "orignal string";
            b(a);
            int[] price = new int[] { 2, 3, 4 };
            foreach (int item in price)
            {
                price[1] = 8;
            }
            //for (int i = 0; i < length; i++)
            //{

            //}
        }

        private void b(string c)
        {
            c ="changed";
        }

    }
}

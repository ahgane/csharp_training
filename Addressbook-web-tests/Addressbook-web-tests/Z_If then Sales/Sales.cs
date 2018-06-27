using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAddressbookTests
{
    [TestClass]
    public class Sales
    {
        [TestMethod]
        public void TestMethod1()
        {
            double total = 900;
            bool VipClient = false;

            if (total > 1000 || VipClient)
                {
                total = total * 0.9;
                System.Console.Out.Write("Скидка 10%, общая сумма " + total);
            }
            else
            {
                System.Console.Out.Write("Хорошего дня! Общая сумма " + total);
            }
        }
    }
}

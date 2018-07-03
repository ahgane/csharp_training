using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    [TestClass]
    public class Cycles
    {
               [TestMethod]
               public void LearningCycles_1()
               {
                   string[] s = new string[] { "I", "want", "to", "sleep", "now" };
                   for (int i = 0; i < s.Length; i++)
                   {
                       System.Console.Out.WriteLine(s[i]);
                   }
               }
               [TestMethod]
               public void LearningCycles_2()
               {
                   string[] s = new string[] { "I", "want", "to", "sleep", "now", "darling" };
                   foreach (string element in s)
                   {
                       System.Console.Out.WriteLine(element);

                   }
               }
       
/*        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = null;
            int attempt = 0;

            while (driver.FindElements(By.Id("tests")).Count == 0 && attempt <60)
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = null;
            int attempt = 0;

            do
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            } while (driver.FindElements(By.Id("tests")).Count == 0 && attempt < 60);
        }*/
    }
}

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvernightExecution
{
    [TestFixture]
    public class Program
    {
        public static void Main(string[] args)
        {
        }

        [Test]
        public void FirstTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Close();
        }
    }
}

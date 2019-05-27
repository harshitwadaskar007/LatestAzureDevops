using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            int first = 1;
            int second = 2;
            int sum = first + second;
            Assert.IsTrue(sum == 3);
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");
            //IWebDriver driver = new ChromeDriver(path,chromeOptions);
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Close();
        }

        [Test]
        public void SecondTest()
        {
            int first = 3;
            int second = 7;
            int sum = first + second;
            Assert.IsTrue(sum == 10 );
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");
            //IWebDriver driver = new ChromeDriver(path, chromeOptions);
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Close();
        }

        [Test]
        public void ThirdTest()
        {
            int first = 3;
            int second = 7;
            int sum = first + second;
            Assert.IsTrue(sum == 1);
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");
            //IWebDriver driver = new ChromeDriver(path, chromeOptions);
            //driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Close();
        }
    }
}

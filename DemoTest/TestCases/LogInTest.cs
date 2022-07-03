using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace DemoTest.TestCases
{
    class LogInTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver(@"C:\Users\Vlad\source\repos\DemoTest\DemoTest");
            driver.Url = "https://demoqa.com";
            driver.FindElement(By.CssSelector("div#app div.home-body > div > div:nth-child(1)")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("div#app div:nth-child(1) > div > ul > li#item-1")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("div#tree-node span.rct-title")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("div#app div:nth-child(1) > div > ul > li#item-2 > span")).Click();
            Thread.Sleep(500); 
            driver.FindElement(By.CssSelector("div#app div:nth-child(3) > label")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("div#app div:nth-child(2) > label")).Click();
            Thread.Sleep(500);
            driver.Quit(); 
        }       
    }
}

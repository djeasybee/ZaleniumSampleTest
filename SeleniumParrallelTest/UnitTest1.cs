using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumParrallelTest
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxBrowserTest :Hooks
    {

        public  FirefoxBrowserTest(): base(BrowserType.Firefox)
        {

        }

        [Test]
        public void FireFoxGoogleTest()
        {

            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[2]/div/div[2]/div[2]/div[1]/div/ul/li[11]/div/span[1]/span/input")).Submit();

            Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true), "The text selenium does not exist");

            Thread.Sleep(2000);
            Driver.Close();
        }

    }

    [Parallelizable]

    [TestFixture]

    public class ChromeBrowserTest :Hooks
    {
        public ChromeBrowserTest() : base(BrowserType.Chrome)
        {
        }


        [Test]
        public void ChromexGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Thread.Sleep(2000);
            Driver.FindElement(By.Name("btnG")).Submit();

            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), "The text selenium does not exist");

            Thread.Sleep(2000);
            Driver.Close();

        }
       
    }
}

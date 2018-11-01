using System;
using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZaleniumSampleTest;

namespace ZaleniumSampleTest
{

    [TestFixture]
    [Parallelizable]

    public class SeleniumFramework : Hooks
    {
        public SeleniumFramework() : base(BrowserType.Firefox)
        {

        }


        [Test]

        public void ExecuteTest()
        {

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("KK", "Bayo", "Akins");


        }

    }

    [TestFixture]
    [Parallelizable]

    public class ChromeBrowserTest : Hooks
    {
        public ChromeBrowserTest() : base(BrowserType.Chrome)
        {
        }


        [Test]
        
        public void ChromexGoogleTest()
        {
            
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("KK", "Bayo", "Akins");

        }

        [Test]
        public void ChromexGoogleTest2()
        {
            
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("KK", "Bayo", "Akins");


            //PropertiesCollections.driver.Navigate().GoToUrl("http://www.google.com");
            //PropertiesCollections.driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
            //Thread.Sleep(2000);
            //PropertiesCollections.driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[2]/div/div[2]/div[2]/div[1]/div/ul/li[11]/div/span[1]/span/input")).Submit();

            //Thread.Sleep(2000);
            //Assert.That(PropertiesCollections.driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true), "The text selenium does not exist");

            //Thread.Sleep(2000);
            //PropertiesCollections.driver.Close();

        }



        [Test]


        public void ChromexGoogleTest3()
        {
           
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("KK", "Bayo", "Akins");


        }


    }

  
}




//ChromeOptions options = new ChromeOptions();
//options.addExtensions(new File("/path/to/extension.crx"));
//ChromeDriver driver = new ChromeDriver(options);
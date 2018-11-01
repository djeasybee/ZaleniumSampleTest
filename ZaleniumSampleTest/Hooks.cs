using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{   

   public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }


    [TestFixture]

    public class Hooks: Base
    {

        public void Chrome()
        {
            
            //PropertiesCollections.driver = new ChromeDriver();
            var options = new ChromeOptions(); options.AddArguments("incognito", "testFileNameTemplate", "myID_{browser}_{testStatus}");

           // _driver.Manage().Timeouts().PageLoad.Minutes.TimeSpan.FromSeconds(5));
           //options.AddAdditionalCapability("idleTimeout", 150);



            PropertiesCollections.driver = _driver = new RemoteWebDriver(
              new Uri("http://localhost:4444/wd/hub"), options);

        }

        public void firex()
        {

            PropertiesCollections.driver = _driver = new FirefoxDriver();

            var Fireoptions = new FirefoxOptions(); Fireoptions.AddArgument("incognito");
            PropertiesCollections.driver = new RemoteWebDriver(
              new Uri("http://localhost:4444/wd/hub"), Fireoptions);
        }

        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        
        [SetUp]

        public void InitializeTest()
        {
            
        ChooseDriverInstance(_browserType);
            PropertiesCollections.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            //_driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }
        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Chrome();
                  
        
            else if (browserType == BrowserType.Firefox)
                firex();


        }

        //[TearDown]

        //public void CleanUP()
        //{
        //   _driver.Quit();
        //    PropertiesCollections.driver.Quit();
        //}
    }
}

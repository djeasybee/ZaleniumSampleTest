using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void chomess()
        {
            PropertiesCollections.driver = new ChromeDriver();
            var options = new ChromeOptions(); options.AddArgument("incognito");
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
                chomess();
                  
        
            else if (browserType == BrowserType.Firefox)
                firex();


        }
    }
}

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumParrallelTest
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
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]

        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }
        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver();

            else if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
        }
    }
}

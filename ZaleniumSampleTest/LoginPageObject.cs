using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{
    class LoginPageObject :Base
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        //private RemoteWebDriver _driver;

        //public LoginPageObject(RemoteWebDriver driver) => _driver = driver;
        //public IWebElement txtUserName => _driver.FindElementByName("UserName");
        //public IWebElement TxtPassword => _driver.FindElementByName("Password");
        //public IWebElement btnLogin => _driver.FindElementByName("Login");

        public EAPageObject Login(string userName, string password)
        {
            //UserName
            txtUserName.EnterText(userName);

            //Password
            txtPassword.EnterText(password);

            //Click Login
            //btnLogin.Clicks();
            btnLogin.Submit();


            Thread.Sleep(2000);
            //Return the page object
            return new EAPageObject();

        }

    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{
    class EAPageObject
    {
        public EAPageObject()
        {
            //PageFactory
            PageFactory.InitElements(PropertiesCollections.driver, this);
        }
        [FindsBy(How =How.Id, Using = "TiteId")]

        public IWebElement ddTitleID { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]

        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]

        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]

        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "SurName")]

        public IWebElement txtSurName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]

        public IWebElement btnSave { get; set; }

        public void FillUserForm(string intial, string middleName, string firstName)
        {
            
             txtInitial.EnterText(intial);
            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            btnSave.Click();

            //SeleniumSetMethods.EnterText(txtInitial, initial);
            //SeleniumSetMethods.EnterText(txtFirstName, firstName);
            //SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            //SeleniumSetMethods.Click(btnSave);


            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtFirstName.SendKeys(middleName);
            //btnSave.Click();
        }


    }
}

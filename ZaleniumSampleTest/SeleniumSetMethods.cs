using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{
    public class SeleniumSetMethods
    {
        public static void EnterText( string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)

                PropertiesCollections.driver.FindElement(By.Id(element)).SendKeys(value);

            if (elementtype ==PropertyType.Name)
                PropertiesCollections.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click( string element,  PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)

                PropertiesCollections.driver.FindElement(By.Id(element)).Click();

            if (elementtype == PropertyType.Name)
                PropertiesCollections.driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)

                new SelectElement(PropertiesCollections.driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollections.driver.FindElement(By.Name(element))).SelectByText(value);


        }
    }
}

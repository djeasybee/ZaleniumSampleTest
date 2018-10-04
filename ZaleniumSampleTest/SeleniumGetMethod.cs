using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{
    class SeleniumGetMethod
    {
        public static string GetText( string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollections.driver.FindElement(By.Id(element)).GetAttribute("value");

            if (elementtype == PropertyType.Name)
                return PropertiesCollections.driver.FindElement(By.Name(element)).Text;

            else return String.Empty;

        }

        public static string GetTextFromDDL(IWebDriver driver, string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollections.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;

            if (elementtype == PropertyType.Name)

                return new SelectElement(PropertiesCollections.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;

            else return String.Empty;

        }


    }
}

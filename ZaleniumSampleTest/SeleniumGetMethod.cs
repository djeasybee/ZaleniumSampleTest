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
        public static string GetText( IWebElement element, PropertyType elementtype)
        {
            return element.GetAttribute("value");
               
        }

        public static string GetTextFromDDL(IWebElement element)
        {
            return new SelectElement (element).AllSelectedOptions.SingleOrDefault().Text;
        
        }


    }
}

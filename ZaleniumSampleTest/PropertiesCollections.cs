﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaleniumSampleTest
{
    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssName
    }
    class PropertiesCollections
    {
        public static IWebDriver driver { get; set; }
    }

 
}

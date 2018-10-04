using System;
using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZaleniumSampleTest;

namespace ZaleniumSampleTest 
{
   
    public class UnitTest1 :SeleniumSetMethods
    {

       

        [SetUp]
        public void Initilaize()
        {
            PropertiesCollections.driver = new ChromeDriver();

            // RemoteWebDriver driver = new RemoteWebDriver(

            //new Uri("http://localhost:4446/wd/hub"), new ChromeOptions());


            PropertiesCollections.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
        }


        [Test]
            public void Test()
            {

            SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);

            SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);
            Console.WriteLine("The Value from my Title is: " + SeleniumGetMethod.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value of my initial is: "+ SeleniumGetMethod.GetText( "Initial", PropertyType.Name));

            SeleniumSetMethods.Click("Save", PropertyType.Name);
           
            Thread.Sleep(1000);
            

            }


        [TearDown]
        public void CleanUP()
        {
            //Close the browser

            Thread.Sleep(00);
            PropertiesCollections.driver.Close();
        }


        

    }
    }




//ChromeOptions options = new ChromeOptions();
//options.addExtensions(new File("/path/to/extension.crx"));
//ChromeDriver driver = new ChromeDriver(options);
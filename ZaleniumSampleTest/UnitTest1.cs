using System;
using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZaleniumSampleTest;

namespace ZaleniumSampleTest 
{
   
    public class SeleniumFramework 
    {
        private RemoteWebDriver driver;

        [SetUp]
        public void Initilaize()
        {
            PropertiesCollections.driver = new ChromeDriver();

            // RemoteWebDriver driver = new RemoteWebDriver(

            //new Uri("http://localhost:4446/wd/hub"), new ChromeOptions());


            PropertiesCollections.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }


        [Test]
            public void ExecuteTest()
            {
            

            LoginPageObject pageLogin = new LoginPageObject(driver);
            //ExcelLib.PopulateInCollection(@"C: \Users\bayo akintunde\Documents\Trainnings\ZaleniumTestFolder\Data.xlsx");
            //EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            //pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));

            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("KK", "Bayo", "Akins");



            //SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);
            // Console.WriteLine("The Value from my Title is: " + SeleniumGetMethod.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value of my initial is: "+ SeleniumGetMethod.GetText( "Initial", PropertyType.Name));

            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            //Thread.Sleep(1000);


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
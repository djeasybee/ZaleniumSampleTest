using System;
using System.Threading;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using ZaleniumSampleTest;

namespace ZaleniumSampleTest 
{
<<<<<<< HEAD
   
    public class SeleniumFramework 
    {
        private RemoteWebDriver driver;
=======
    [Parallelizable]
    [TestFixture]
>>>>>>> refs/remotes/origin/master

    public class SeleniumFramework :Hooks
    {
        public SeleniumFramework() : base(BrowserType.Firefox)
        {

        }
        


        [Test]
            public void ExecuteTest()
            {          

<<<<<<< HEAD
            LoginPageObject pageLogin = new LoginPageObject(driver);
=======
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("KK", "Bayo", "Akins");


>>>>>>> refs/remotes/origin/master
            //ExcelLib.PopulateInCollection(@"C: \Users\bayo akintunde\Documents\Trainnings\ZaleniumTestFolder\Data.xlsx");
            //EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            //pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));



            //SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);
            // Console.WriteLine("The Value from my Title is: " + SeleniumGetMethod.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value of my initial is: "+ SeleniumGetMethod.GetText( "Initial", PropertyType.Name));

            //SeleniumSetMethods.Click("Save", PropertyType.Name);

            //Thread.Sleep(1000);

        }


        [Parallelizable]

        [TestFixture]

        public class ChromeBrowserTest : Hooks
        {
            public ChromeBrowserTest() : base(BrowserType.Chrome)
            {
            }


            [Test]
            public void ChromexGoogleTest()
            {
                LoginPageObject pageLogin = new LoginPageObject();
                EAPageObject pageEA = pageLogin.Login("execute", "automation");

                pageEA.FillUserForm("KK", "Bayo", "Akins");


                //PropertiesCollections.driver.Navigate().GoToUrl("http://www.google.com");
                //PropertiesCollections.driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
                //Thread.Sleep(2000);
                //PropertiesCollections.driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[2]/div/div[2]/div[2]/div[1]/div/ul/li[11]/div/span[1]/span/input")).Submit();

                //Thread.Sleep(2000);
                //Assert.That(PropertiesCollections.driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true), "The text selenium does not exist");

                //Thread.Sleep(2000);
                //PropertiesCollections.driver.Close();

            }

        }


        [TearDown]
        public void CleanUP()
        {
            //Close the browser

            Thread.Sleep(00);
            PropertiesCollections.driver.Close();
            PropertiesCollections.driver.Quit();

            
           
        }

        
    }
    }




//ChromeOptions options = new ChromeOptions();
//options.addExtensions(new File("/path/to/extension.crx"));
//ChromeDriver driver = new ChromeDriver(options);
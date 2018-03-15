using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingJquerySelenium;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;

namespace SeleniumFramework
{
    [TestClass]
    public class PruebaAutomatizadaChrome : WebDriverFucTest
    {
        //http://www.automationtestinghub.com/selenium-3-launch-microsoft-edge-with-microsoftwebdriver/
        //https://www.microsoft.com/en-us/download/confirmation.aspx?id=48212
        //https://automatetheplanet.com/selenium-webdriver-csharp-cheat-sheet/
        //info instaces last up date https://www.seleniumhq.org/docs/03_webdriver.jsp


        public void caso1()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            int[] with = { 1000, 1000 };
            int[] Height = { 1000, 1000 };
            this.InicioFotos(driver, CrearDirectorioYDevolverRuta("C:\\Imagenes", "TestMethod1Chrome"), with, Height);
            IWebElement element = driver.FindElement(By.Id("lst-ib"));
            element.SendKeys("Novatesting");
            IWebElement element2 = driver.FindElement(By.Name("btnK"));
            element2.Click();
            IWebElement element3 = driver.FindElement(By.LinkText("NOVATesting"));
            element3.Click();
            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void TestMethod1Chrome1()
        {    WebDriverChrome InstaciaChrome = new WebDriverChrome();
            driver= InstaciaChrome.driver;
            caso1();
        }
        [TestMethod]
        public void TestMethod1FireFox1()
        {
            //info instaces last up date https://www.seleniumhq.org/docs/03_webdriver.jsp
         WebDriverFF InstaciaFF = new WebDriverFF();
           // FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\DRIVERS\geckodriver-v0.19.1-win64", "geckodriver.exe");
          //  service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\Firefox.exe";
            //var profile = new FirefoxProfile { EnableNativeEvents = true };
         // IWebDriver  driver2 = new FirefoxDriver(service);
         //   driver2.Navigate().GoToUrl("https://www.google.com");
        driver = InstaciaFF.driver;
       caso1();
        }
        [TestMethod]
        public void TestMethod1EdgeDriver1()
        {
            //info instaces last up date https://www.seleniumhq.org/docs/03_webdriver.jsp
            // driver = new EdgeDriver ();
            string serverPath = @"C:\Program Files (x86)\Microsoft Web Driver\";
            string serverPath2 = @"C:\DRIVERS\";

            EdgeOptions options = new EdgeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
           // driver = new EdgeDriver(serverPath, options);
            driver = new EdgeDriver();
            caso1();
        }
        [TestMethod]
        public void TestMethod1Opera1()
        {
            //info instaces last up date https://www.seleniumhq.org/docs/03_webdriver.jsp
            // driver = new EdgeDriver ();
           string serverPath2 = @"C:\DRIVERS\operadriver_win32\";
            string serverPath1 = @"C:\DRIVERS\operadriver_win64\";

            driver = new OperaDriver(serverPath1);
            caso1();
        }
    }
}

using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestingJquerySelenium
{
   public class WebDriverFF:WebDriver
    {
        public WebDriverFF()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\DRIVERS");
            service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\Firefox.exe";
            //var profile = new FirefoxProfile { EnableNativeEvents = true };
            FirefoxOptions option = new FirefoxOptions();
            option.AddArgument("no-sandbox");
            option.AddAdditionalCapability("acceptInsecureCerts", true, true);
            //  driver = new FirefoxDriver(service, option, TimeSpan.FromSeconds(180));
            driver = new FirefoxDriver();
           driver.Navigate().GoToUrl("https://www.google.com");
            // driver = new FirefoxDriver(); 

        }
    }
}

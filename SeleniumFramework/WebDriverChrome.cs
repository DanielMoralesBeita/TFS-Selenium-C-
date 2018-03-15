using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestingJquerySelenium
{
   public class WebDriverChrome : WebDriver
    {
        public WebDriverChrome()
        {
            driver = new ChromeDriver(@"C:\DRIVERS\");
            
         
        }
    }
}

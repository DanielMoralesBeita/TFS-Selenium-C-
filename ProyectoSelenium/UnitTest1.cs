using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyectoSelenium
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;
    using OpenQA.Selenium.Chrome;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using System.Web;
    using System.Net;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using System.Drawing.Imaging;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    namespace SeleniumTests
    {
        [TestClass]
        public class CasoDePruebaCinaMark
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                // driver = new FirefoxDriver();
                driver = new ChromeDriver(@"C:\DRIVERS\");
                baseURL = "https://www.cinemarkca.com/es";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
             //   Assert.AreEqual("", verificationErrors.ToString());
            }

            [TestMethod]
            public void TheCasoDePruebaCinaMarkTest()
            {
                driver = new ChromeDriver(@"C:\DRIVERS\");
                baseURL = "https://www.cinemarkca.com/es";
                verificationErrors = new StringBuilder();
                driver.Navigate().GoToUrl("https://www.cinemarkca.com/es");
                driver.FindElement(By.LinkText("Costa Rica")).Click();
                Thread.Sleep(500);
                driver.FindElement(By.LinkText("Multiplaza Escazú")).Click();
                Thread.Sleep(2000);
              //  IList<IWebElement> links = driver.FindElements(By.TagName("a"));
              //  links.First(element => element.GetAttribute("href") == "https://www.cinemarkca.com/es/movies/el-robo-perfecto?theatre=costa-rica-multiplaza-escazu").Click();
                // driver.FindElement(By.LinkText("15:15")).Click();\
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//div[@id='digital_2d']/li/div[3]/div[2]")).Click();

                Thread.Sleep(500);
                driver.FindElement(By.XPath("//img[contains(@src,'https://cinemarkpy.modyocdn.com/uploads/c26ca6ba-3275-46f3-bc37-135ef48f90c6/original/ROBO_PERFECTO_POSTER.jpg')]")).Click();
                Thread.Sleep(1500);
                driver.FindElement(By.LinkText("19:00")).Click();
                Thread.Sleep(1500);
               
           // ((IJavaScriptExecutor)driver).ExecuteScript(" (function() {if (!window['___grecaptcha_cfg']) { window['___grecaptcha_cfg'] = {}; };if (!window['___grecaptcha_cfg']['render']) { window['___grecaptcha_cfg']['render'] = 'onload'; };window['__google_recaptcha_client'] = true;var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;po.src = 'ht'; var elem = document.querySelector('script[nonce]');var nonce = elem && (elem['nonce'] || elem.getAttribute('nonce'));if (nonce) { po.setAttribute('nonce', nonce); }var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);})();");
             //   string algo = "$(\"span#recaptcha-anchor.recaptcha-checkbox.goog-inline-block.recaptcha-checkbox-unchecked.rc-anchor-checkbox\").click();";
               // ((IJavaScriptExecutor)driver).ExecuteScript(algo);
                  /*
                
                 */



                List <String> tab_handles = driver.WindowHandles.ToList();
                int number_of_tabs = tab_handles.Count();
                int new_tab_index = number_of_tabs - 1;
                driver.SwitchTo().Window(tab_handles[new_tab_index]);
               
             
                // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
                //driver.FindElement(By.XPath("(//button[@type='button'])[4]")).Click();
                //Thread.Sleep(1500);
               // driver.FindElement(By.XPath("//button[@id='ibtnOrderTickets']/span")).Click();
                // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
                driver.FindElement(By.XPath("(//button[@type='button'])[4]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//button[@id='ibtnOrderTickets']/span")).Click();
                Thread.Sleep(2000);
                Thread.Sleep(32000);
                driver.FindElement(By.XPath("//table[@id='1']/tbody/tr[8]/td[6]/p")).Click();
                Thread.Sleep(2000);
                Thread.Sleep(32000);
                driver.FindElement(By.XPath("//button[@id='ibtnNext']/span")).Click();
                Thread.Sleep(32000);
                driver.FindElement(By.XPath("(//button[@type='button'])[26]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//button[@id='btnConcessionsNext']/span")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("gift-card-number")).Click();
                driver.FindElement(By.Id("name")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("email")).SendKeys("Pedroperez@gmail.com");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("Pedroperez");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//form[@id='confirmForm']/div[6]/div[2]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("terms-conditions-agree")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//button[@id='next']/span")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-number")).Click();
                driver.FindElement(By.Id("card-number")).Clear();
                driver.FindElement(By.Id("card-number")).SendKeys("123542342134231");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//form[@id='paymentForm']/div[6]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-name")).Click();
                driver.FindElement(By.Id("card-name")).Clear();
                driver.FindElement(By.Id("card-name")).SendKeys("234124234");
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//form[@id='paymentForm']/div[6]/span")).Click();
                driver.FindElement(By.Id("card-name")).Clear();
                driver.FindElement(By.Id("card-name")).SendKeys("Pedro perez");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-cvc")).Click();
                driver.FindElement(By.Id("card-cvc")).Clear();
                driver.FindElement(By.Id("card-cvc")).SendKeys("0220");
                Thread.Sleep(2000);
                // ERROR: Caught exception [ERROR: Unsupported command [selectFrame | index=1 | ]]
                ((IJavaScriptExecutor)driver).ExecuteScript(" (function() {if (!window['___grecaptcha_cfg']) { window['___grecaptcha_cfg'] = {}; };if (!window['___grecaptcha_cfg']['render']) { window['___grecaptcha_cfg']['render'] = 'onload'; };window['__google_recaptcha_client'] = true;var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;po.src = 'ht'; var elem = document.querySelector('script[nonce]');var nonce = elem && (elem['nonce'] || elem.getAttribute('nonce'));if (nonce) { po.setAttribute('nonce', nonce); }var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);})();");
                string algo = "$(\"span#recaptcha-anchor.recaptcha-checkbox.goog-inline-block.recaptcha-checkbox-unchecked.rc-anchor-checkbox\").click();";
                ((IJavaScriptExecutor)driver).ExecuteScript(algo);
                //  driver.FindElement(By.XPath("//span[@id='recaptcha-anchor']/div[5]")).Click();
                Thread.Sleep(2000);
               // ERROR: Caught exception [ERROR: Unsupported command [selectFrame | relative=parent | ]]
                driver.FindElement(By.Id("card-cvc")).Click();
                driver.FindElement(By.Id("card-cvc")).Click();
                driver.FindElement(By.Id("card-cvc")).Clear();
                driver.FindElement(By.Id("card-cvc")).SendKeys("022");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("paymentForm")).Click();
                driver.FindElement(By.XPath("//button[@id='pay']/span")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-expiry-month")).Click();
                new SelectElement(driver.FindElement(By.Id("card-expiry-month"))).SelectByText("02");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-expiry-month")).Click();
                driver.FindElement(By.Id("card-expiry-year")).Click();
                new SelectElement(driver.FindElement(By.Id("card-expiry-year"))).SelectByText("2020");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("card-expiry-year")).Click();
                driver.FindElement(By.XPath("//button[@id='pay']/span")).Click();
                driver.FindElement(By.XPath("//form[@id='paymentForm']/span")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//form[@id='paymentForm']/p")).Click();
                Thread.Sleep(2000);
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }

}

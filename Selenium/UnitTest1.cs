using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

 
        [TestFixture]
    [TestClass]
    public class NuevaPruebaSelenium
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;

            [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                baseURL = "https://www.katalon.com/";
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
            NUnit.Framework.Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
        [TestMethod]
        public void TheNuevaPruebaSeleniumTest()
            {
            int tiempoEspera = 300;
            driver = new ChromeDriver(@"C:\DRIVERS\");
            baseURL = "https://www.cinemarkca.com/es";
            verificationErrors = new StringBuilder();
           
            driver.Navigate().GoToUrl("https://www.cinemarkca.com/es");
                driver.FindElement(By.LinkText("Costa Rica")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.LinkText("Multiplaza Curridabat")).Click();
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//div[@id='digital_2d']/li/div[3]/div")).Click();
            Thread.Sleep(tiempoEspera);
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//div[@id='digital_2d']/li/div[3]/div")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//img[contains(@src,'https://cinemarkpy.modyocdn.com/uploads/c26ca6ba-3275-46f3-bc37-135ef48f90c6/original/ROBO_PERFECTO_POSTER.jpg')]")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.LinkText("20:35")).Click();
            Thread.Sleep(tiempoEspera);
            //Correcion de error.
            List<String> tab_handles = driver.WindowHandles.ToList();
            int number_of_tabs = tab_handles.Count();
            int new_tab_index = number_of_tabs - 1;
            driver.SwitchTo().Window(tab_handles[new_tab_index]);

            Thread.Sleep(tiempoEspera);
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            driver.FindElement(By.XPath("(//button[@type='button'])[4]")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//button[@id='ibtnOrderTickets']/span")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//table[@id='1']/tbody/tr[8]/td[13]/p")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//button[@id='ibtnNext']/span")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("(//button[@type='button'])[26]")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("(//button[@type='button'])[18]")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("(//button[@type='button'])[10]")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//button[@id='btnConcessionsNext']/span")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("name")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("email")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("email")).Clear();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("email")).SendKeys("algo@nuevo.com");
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("name")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("name")).Clear();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("name")).SendKeys("algo");
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("terms-conditions-agree")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//button[@id='next']/span")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-number")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-number")).Clear();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-number")).SendKeys("12334675");
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-name")).Clear();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-name")).SendKeys("algo");
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//form[@id='paymentForm']/div[8]/label")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-cvc")).Click();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-cvc")).Clear();
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.Id("card-cvc")).SendKeys("123");
            Thread.Sleep(tiempoEspera);
            driver.FindElement(By.XPath("//button[@id='pay']/span")).Click();
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

 

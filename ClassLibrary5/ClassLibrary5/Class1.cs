using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary5
{
    [TestFixture]
    public class class1
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
            Assert.AreEqual("", verificationErrors.ToString());
        }
        [TestFixture]
        public class Test1
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
                Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
            public void Inputvaliddata_returnvalidURLTest()
            {
                driver.Navigate().GoToUrl("http://localhost/Project/form.php");
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("happy");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("789");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("kitchener");
                driver.FindElement(By.Id("phone_no")).Click();
                driver.FindElement(By.Id("phone_no")).Clear();
                driver.FindElement(By.Id("phone_no")).SendKeys("566-897-6790");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("happ123@gmail.com");
                driver.FindElement(By.Id("make")).Click();
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Ford");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("Ranger");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2019");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year'])[1]/following::input[2]")).Click();
                driver.FindElement(By.XPath("//html")).Click();
                driver.FindElement(By.LinkText("https://www.jdpower.com/cars/2019/ford/ranger")).Click();
                Thread.Sleep(9000);
                Assert.IsTrue(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Displayed);
            }


            [Test]
            public void TheInputunfilledphonenumber_ReturnalertmessageTest()
            {
                driver.Navigate().GoToUrl("http://localhost/Project/assign4.html");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search your Car here..:)'])[1]/following::button[1]")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("harsh");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("345");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("kitchener");
                driver.FindElement(By.Id("phone_no")).Click();
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("amn@gmn.com");
                driver.FindElement(By.Id("make")).Click();
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Ford");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("Ecosport");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year'])[1]/following::input[2]")).Click();
                Assert.AreEqual("", driver.FindElement(By.Id("phone_no")).Text);
            }
            [Test]
            public void TheInputmakenamewithespace_ReturndetailofnamedcarTest()
            {
                driver.Navigate().GoToUrl("http://localhost/Project/assign4.html");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search your Car here..:)'])[1]/following::button[1]")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("Jerry");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("567 west");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("waterloo");
                driver.FindElement(By.Id("phone_no")).Click();
                driver.FindElement(By.Id("phone_no")).Clear();
                driver.FindElement(By.Id("phone_no")).SendKeys("226-335-3456");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("asd@ghj.bnm");
                driver.FindElement(By.Id("make")).Click();
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Rolls-Royce");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("Dawn");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2017");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year'])[1]/following::input[2]")).Click();
                Assert.AreEqual("Rolls-Royce", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='asd@ghj.bnm'])[1]/following::td[1]")).Text);
            }
            [Test]
            public void TheInputmodelnamewithespaceReturndetailofnamedcarTest()
            {
                driver.Navigate().GoToUrl("http://localhost/Project/assign4.html");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Search your Car here..:)'])[1]/following::button[1]")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("Herry");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("890 westmount");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("waterloo");
                driver.FindElement(By.Id("phone_no")).Click();
                driver.FindElement(By.Id("phone_no")).Clear();
                driver.FindElement(By.Id("phone_no")).SendKeys("(566)456-6789");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("ghj@gmail.com");
                driver.FindElement(By.Id("make")).Click();
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Jaguar");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("E-Pace");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2018");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year'])[1]/following::input[2]")).Click();
                Assert.AreEqual("E-Pace", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Jaguar'])[1]/following::td[1]")).Text);


            }

            [Test]
            public void TheInputinvaliddataReturn404errorTest()
            {
                driver.Navigate().GoToUrl("http://localhost/Project/assign4.html");
                driver.FindElement(By.XPath("//button[@onclick=\"window.location.href ='form.php'\"]")).Click();
                driver.FindElement(By.Id("name")).Click();
                driver.FindElement(By.Id("name")).Clear();
                driver.FindElement(By.Id("name")).SendKeys("Ram");
                driver.FindElement(By.Id("address")).Click();
                driver.FindElement(By.Id("address")).Clear();
                driver.FindElement(By.Id("address")).SendKeys("420 street");
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Click();
                driver.FindElement(By.Id("city")).Clear();
                driver.FindElement(By.Id("city")).SendKeys("London");
                driver.FindElement(By.Id("phone_no")).Click();
                driver.FindElement(By.Id("phone_no")).Clear();
                driver.FindElement(By.Id("phone_no")).SendKeys("(456)789-0987");
                driver.FindElement(By.Id("email")).Click();
                driver.FindElement(By.Id("email")).Clear();
                driver.FindElement(By.Id("email")).SendKeys("ram67@gmail.com");
                driver.FindElement(By.Id("make")).Click();
                driver.FindElement(By.Id("make")).Clear();
                driver.FindElement(By.Id("make")).SendKeys("Alfa Romeo");
                driver.FindElement(By.Id("model")).Click();
                driver.FindElement(By.Id("model")).Clear();
                driver.FindElement(By.Id("model")).SendKeys("Ford");
                driver.FindElement(By.Id("year")).Click();
                driver.FindElement(By.Id("year")).Clear();
                driver.FindElement(By.Id("year")).SendKeys("2017");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Vehicle Year'])[1]/following::input[2]")).Click();
                driver.FindElement(By.LinkText("https://www.jdpower.com/cars/2017/alfa-romeo/ford")).Click();
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


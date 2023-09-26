using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_example
{
    class MyFirstSelenium
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\chromedriver\\chromedriver-win64\\chromedriver.exe");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://localhost:44316/";

            driver.FindElement(By.Id("navbar-about")).Click();
            driver.FindElement(By.Id("about-title")).Displayed.Equals(true);

            driver.FindElement(By.Id("navbar-contact")).Click();
            driver.FindElement(By.Id("contact-title")).Displayed.Equals(true);

            driver.FindElement(By.Id("navbar-home")).Click();
            driver.FindElement(By.Id("home-title")).Displayed.Equals(true);
        }

        [TearDown]
        public void closeBrowser()
        {
            //driver.Close();
        }
    }
}

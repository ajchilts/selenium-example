using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            driver.Url = "https://localhost:44316/";

            var aboutLink = driver.FindElement(By.Id("navbar-about"));
            wait.Until(d => aboutLink.Displayed);
            aboutLink.Click();

            var aboutPage = driver.FindElement(By.Id("about-title"));
            wait.Until(d => aboutPage.Displayed);

            var contactLink = driver.FindElement(By.Id("navbar-contact"));
            wait.Until(d => contactLink.Displayed);
            contactLink.Click();

            var contactPage = driver.FindElement(By.Id("contact-title"));
            wait.Until(d => contactPage.Displayed);

            var homeLink = driver.FindElement(By.Id("navbar-home"));
            wait.Until(d => homeLink.Displayed);
            homeLink.Click();

            var homePage = driver.FindElement(By.Id("home-title"));
            wait.Until(d => homePage.Displayed);
        }

        private void wait(bool displayed)
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}

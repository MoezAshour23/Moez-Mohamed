using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FbAutomatedTests.PageObjects;
using SeleniumExtras.PageObjects;
using FbAutomatedTests.Properties;


namespace FbAutomatedTests.TestCases
{
    class LoginTest
    {
        [Test, Order(2)]
        public void Test()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = Resources.SigninUrl;
            driver.Manage().Window.Maximize();
            var loginPage = new LoginPage(driver);

            loginPage.LoginToFb("FbTest");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Quit();
            


        }
    }
}

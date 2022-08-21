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
using System.Configuration;
using FbAutomatedTests.Properties;




namespace FbAutomatedTests.TestCases
{
    class RegistrationTest
    {
        [Test, Order(1)]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = Resources.SignupUrl;

            driver.Manage().Window.Maximize();

            var RegistrationPage = new RegistrationPage(driver);

            RegistrationPage.RegisterToFb("FbTest");
            driver.Quit();
            
        }
    }
}




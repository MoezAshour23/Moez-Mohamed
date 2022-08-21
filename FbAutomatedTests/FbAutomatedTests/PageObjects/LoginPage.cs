using System;
using System.Collections.Generic;
using System.Text;
using FbAutomatedTests.TestCases;
using FbAutomatedTests.TestDataAccess;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FbAutomatedTests.PageObjects
{
    class LoginPage
    {

        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement Login { get; set; }

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void LoginToFb(string FbTest)
        {
            var userData = ExcelDataAccess.GetTestData(FbTest);
            //Enter your Email
            Email.SendKeys(userData.EmailAddress);
            //Enter your Password
            Password.SendKeys(userData.Password);
            //Click on login button
            Login.Click();


            
        }
    }

}

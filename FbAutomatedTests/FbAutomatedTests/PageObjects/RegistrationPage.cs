using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using FbAutomatedTests.TestDataAccess;

namespace FbAutomatedTests.PageObjects
{

    class RegistrationPage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement SurName { get; set; }

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        [CacheLookup]
        public IWebElement CEmailAddress { get; set; }

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "day")]
        [CacheLookup]
        public IWebElement Day { get; set; }

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public IWebElement Month { get; set; }

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public IWebElement Year { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[1]/div[1]/div[2]/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[2]/label")]
        [CacheLookup]
        public IWebElement gender { get; set; }

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement SignUp { get; set; }

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void RegisterToFb(string FbTest)
        {
            var userData = ExcelDataAccess.GetTestData(FbTest);
            // Enter First Name 
            FirstName.SendKeys(userData.FirstName);


            // Enter SurName 
            SurName.SendKeys(userData.SurName);


            // Enter Email 
            EmailAddress.SendKeys(userData.EmailAddress);


            // ReEnter Email 
            CEmailAddress.SendKeys(userData.CEmailAddress);


            // Enter Password
            Password.SendKeys(userData.Password);

            // Find the element for (Date of birth):
            // Enter Day 
            SelectElement SelectDay = new SelectElement(Day);
            SelectDay.SelectByText("18");
            // Enter Month on the element found.
            SelectElement SelectMonth = new SelectElement(Month);
            SelectMonth.SelectByText("Oct");
            // Enter Year on the element found.
            SelectElement SelectYear = new SelectElement(Year);
            SelectYear.SelectByText("1992");


            //Select your gender
            gender.Click();

            // Now SignUp
             SignUp.Click();
        }
    }
}

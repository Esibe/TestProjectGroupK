using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupK.Utilities;

namespace TestProjectGroupK.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;

        }
        IWebDriver driver;
        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/button"));
        IWebElement GlobalFeed => driver.FindElement(By.XPath("(//a[@class='nav-link'])[5]"));



        public void ClickOnSignUp()
        {
            SignUp.Click();
        }
        public void EnterUsername()
        {
            Username.SendKeys("Nap6");
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void EnterEmail()
        {
            Email.SendKeys("napesibe6@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("NAPY6");
        }

        public void ClickSignUpButton()

        {
            SignUpButton.Click();
        }

        public bool IsGlobalFeedDisplayed()
        {
            return GlobalFeed.Displayed;

}






    }
}


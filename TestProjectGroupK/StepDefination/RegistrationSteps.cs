using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectGroupK.PageObject;

namespace TestProjectGroupK.StepDefination
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }







        public static IWebDriver driver;
        [Given(@"I navigated to the website")]
        public void GivenINavigatedToTheWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on sign up")]
        public void GivenIClickOnSignUp()
        {
            Thread.Sleep(5000);
            registrationPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            registrationPage.EnterUsername();
        }
        
        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my Passward")]
        public void GivenIEnterMyPassward()
        {
            Thread.Sleep(5000);
            registrationPage.EnterPassword();
        }
        
        [When(@"when I click on Sign up button")]
        public void WhenWhenIClickOnSignUpButton()
        {
            registrationPage.ClickSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsGlobalFeedDisplayed);
                }
        
           
        }
    }


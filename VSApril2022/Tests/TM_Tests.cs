
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using VSApril2022.Pages;

namespace VSApril2022.Tests
{
    internal class TM_Tests
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TM Page initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

            //Edit TM
            tMPageObj.EditTM(driver);

            //Delete TM
            tMPageObj.DeleteTM(driver);
        }
    }
}


using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VSApril2022.Utilities;

namespace VSApril2022.Pages
{
    internal class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // Got to TM page

            // Click on Administration Menu list
            IWebElement administrationList = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationList.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 5);

            // Select Material and Time from the list
            IWebElement timeMaterialButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialButton.Click();
            Thread.Sleep(1000);
        }
    }
}


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
    internal class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            // Click on Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();
            Thread.Sleep(2000);

            // Select Material from Type Code
            IWebElement typeCodeList = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeList.Click();
            Thread.Sleep(2000);

            // Identify code textbox and enter valid code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("test");
            Thread.Sleep(2000);

            // Identify description textbox and enter valid description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Testing description box");
            Thread.Sleep(2000);

            // Identify price textbox and ente valid amount
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("150");
            Thread.Sleep(2000);

            // Click select file button  and upload valid file
            /*IWebElement fileButton = driver.FindElement(By.Id("files"));
            fileButton.SendKeys("C:\\Users\\donap\\OneDrive\\Documents\\test.txt");*/

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);


            // Click on to go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 5);

            //Check if record create is present in the table and has expected value.
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualCode.Text == "test")
            {
                Console.WriteLine("Material record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
        }
        public void EditTM(IWebDriver driver) 
        { 

        }
        public void DeleteTM(IWebDriver driver)
        {

        }
    }
}

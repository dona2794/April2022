using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace VSApril2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            // launch Turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("Hari");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));  

            if(helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully.Test passed");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }

            // Click on Administration Menu list
            IWebElement administrationList = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationList.Click();
            Thread.Sleep(1000);

            // Select Material and Time from the list
            IWebElement timeMaterialButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialButton.Click();
            Thread.Sleep(1000);

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
            Thread.Sleep(10000);

            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[1]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(50000);

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


            driver.Quit();
        }
    }
}

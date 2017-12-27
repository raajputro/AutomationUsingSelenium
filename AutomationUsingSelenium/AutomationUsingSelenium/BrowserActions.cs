using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationUsingSelenium
{
    public class BrowserActions : BrowserClass
    {
        public void LoginFacebook(string url, string uName, string pWord)
        {
            browserDriver.Manage().Window.Maximize();

            browserDriver.Url = url;

            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);              //this wait is necessary to find logout label by webdriver

            IWebElement userNameTextBox = browserDriver.FindElement(By.Name("email"));
            IWebElement passWordTextBox = browserDriver.FindElement(By.Name("pass"));
            IWebElement loginButton = browserDriver.FindElement(By.Id("loginbutton"));

            userNameTextBox.SendKeys(uName);
            passWordTextBox.SendKeys(pWord);

            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);              //this wait is necessary to find logout label by webdriver

            loginButton.Click();


            var wallButton = browserDriver.FindElement(By.XPath(".//*[@id=\"" + "u_0_c" + "\"]/a"));
            //var wallButton = browserDriver.FindElement(By.Id("u_0_c"));
            wallButton.Click();

            ////*[@id="u_0_a"]/div[1]/div[1]/div/a
            var profileButton = browserDriver.FindElement(By.XPath(".//*[@id=\"" + "u_0_a" + "\"]/div[1]/div[1]/div/a"));
            //var profileButton = browserDriver.FindElement(By.Id("u_0_a"));
            profileButton.Click();

            var notificationCount = browserDriver.FindElement(By.Id("notificationsCountValue"));
            var value = notificationCount.Text;

            var notiValue = (value == "") ? 1 : Convert.ToInt32(value);
            if (notiValue > 0)
            {
                var notificationButton = browserDriver.FindElement(By.Id("fbNotificationsJewel"));
                notificationButton.Click();
            }
        }

        public void LogoutFacebook()
        {
            var navigateLabel = browserDriver.FindElement(By.Id("userNavigationLabel"));
            navigateLabel.Click();

            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);              //this wait is necessary to find logout label by webdriver

            var logoutLabel = browserDriver.FindElement(By.XPath("//li[12]/a/span/span"));
            logoutLabel.Click();
        }

        // Actual Project Works ... ...
        public void SiteLogin(string url, string uName, string pWord)
        {
            browserDriver.Manage().Window.Maximize();

            browserDriver.Url = url;

            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);              //this wait is necessary to find logout label by webdriver

            // validating user...
            IWebElement userNameTextBox = browserDriver.FindElement(By.Id("txtUserID"));
            IWebElement validateBtn = browserDriver.FindElement(By.Id("btnValidate"));

            userNameTextBox.Clear();                        // clearing text box, if it has any input
            userNameTextBox.SendKeys(uName);
            validateBtn.Click();

            //logging in with user...
            userNameTextBox = browserDriver.FindElement(By.Id("txtUserID"));
            IWebElement passWordTextBox = browserDriver.FindElement(By.Id("txtPassword"));
            IWebElement loginButton = browserDriver.FindElement(By.Id("btnLogin"));

            userNameTextBox.Clear();                    // clearing text box, if it has any input
            userNameTextBox.SendKeys(uName);
            passWordTextBox.Clear();                    // clearing text box, if it has any input
            passWordTextBox.SendKeys(pWord);

            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);              //this wait is necessary to find logout label by webdriver

            loginButton.Click();
        }

        public void SiteLogout()
        {
            var navigateLabel = browserDriver.FindElement(By.PartialLinkText("Log Off"));
            navigateLabel.Click();
        }

        // utility methods
        public void ClickOnPartialLinkText(string partialLinkText)
        {
            var clickLink = browserDriver.FindElement(By.PartialLinkText(partialLinkText));
            clickLink.Click();
            browserDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);              //this wait is necessary to find logout label by webdriver
        }
        // utility methods
        public void InputOnTextBox(string textBoxId, string textBoxInput)
        {
            var textBox = browserDriver.FindElement(By.Id(textBoxId));
            textBox.Clear();
            textBox.SendKeys(textBoxInput);
        }


        public void PerformSomeTasks()
        {
            var searchText = "NPA Market Dynamics";
            var textBoxId = @"searchProductsText";

            InputOnTextBox(textBoxId, searchText);

            searchText = "NPA Market Dynamics";
            ClickOnPartialLinkText(searchText);

            searchText = @"Source of Business";
            ClickOnPartialLinkText(searchText);

            searchText = @"Performance Data";
            ClickOnPartialLinkText(searchText);
        }
    }
}

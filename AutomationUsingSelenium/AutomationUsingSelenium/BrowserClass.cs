using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using OpenQA.Selenium;
using ch = OpenQA.Selenium.Chrome;
using ff = OpenQA.Selenium.Firefox;
using ie = OpenQA.Selenium.IE;
using ed = OpenQA.Selenium.Edge;


namespace AutomationUsingSelenium
{
    public class BrowserClass
    {
        public IWebDriver browserDriver;

        static string driverAddress = @"E:\My Projects\BrowserDriver";
        static string alternativeDriverAddress = @"";

        public void StartBrowser(string browserType)
        {
            switch (browserType.ToUpper())
            {
                case "CH": browserDriver = new ch.ChromeDriver(driverAddress); break;
                case "FF": browserDriver = new ff.FirefoxDriver(driverAddress); break;
                case "IE": browserDriver = new ie.InternetExplorerDriver(driverAddress); break;
                case "ED": browserDriver = new ed.EdgeDriver(driverAddress); break;
            }
        }

        public void BrowseUrl(string url)
        {
            browserDriver.Url = url;
            browserDriver.Manage().Window.Maximize();
        }

        public void NewTab(string url)
        {
            // codes for opening url
            // in new tab
        }

        public void CloseBrowser()
        {
            browserDriver.Quit();
        }
    }
}

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

        public void StartBrowser(string browserType)
        {
            switch (browserType.ToUpper())
            {
                case "CH": browserDriver = new ch.ChromeDriver(@"E:\My Projects\BrowserDriver"); break;
                case "FF": browserDriver = new ff.FirefoxDriver(@"E:\My Projects\BrowserDriver"); break;
                case "IE": browserDriver = new ie.InternetExplorerDriver(@"E:\My Projects\BrowserDriver"); break;
                case "ED": browserDriver = new ed.EdgeDriver(@"E:\My Projects\BrowserDriver"); break;
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

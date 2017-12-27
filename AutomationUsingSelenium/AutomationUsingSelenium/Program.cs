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
    public class Program
    {
        static void Main(string[] args)
        {
            //var bc = new BrowserClass();
            var ba = new BrowserActions();

            var url = @"http://www.facebook.com";
            var usrName = @"bukka.reddy1@gmail.com";
            var pasWord = @"me@020486";

            //var usrName = @"najib4u@gmail.com";
            //var pasWord = @"i@mn@j1B";


            var url2 = @"https://customerportal.imshealth.com/sites/imsportal/products";
            var usrName2 = @"mmoreschi@us.imshealth.com";
            var pasWord2 = @"alexa99";



            Console.WriteLine("For Chrome, press C");
            Console.WriteLine("For Edge, press E");
            Console.WriteLine("For Firefox, press F");
            Console.WriteLine("For Internet Explorer, press I");
            var browser = Console.ReadLine();

            switch(browser.ToUpper())
            {
                case "I":
                    ba.StartBrowser("IE"); break;
                case "C":
                    ba.StartBrowser("CH"); break;
                case "F":
                    ba.StartBrowser("FF"); break;
                case "E":
                    ba.StartBrowser("ED"); break;
            }

            ////ba.BrowseUrl(url);
            ////Console.WriteLine(@"Open page's Title is = " + ba.browserDriver.Title);
            //////Console.ReadKey();

            //ba.LoginFacebook(url, usrName, pasWord);
            //Console.WriteLine(@"Open page's Title is = " + ba.browserDriver.Title);
            //Console.ReadKey();

            //ba.LogoutFacebook();
            //Console.WriteLine(@"Open page's Title is = " + ba.browserDriver.Title);
            //Console.ReadKey();

            ba.SiteLogin(url2, usrName2, pasWord2);
            Console.ReadKey();

            ba.PerformSomeTasks();
            Console.ReadKey();

            ba.SiteLogout();
            Console.ReadKey();

            ba.CloseBrowser();
        }
    }
}

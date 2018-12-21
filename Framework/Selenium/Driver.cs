using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string Title
        {
            get { return Instance.Title; }
        }

        public static string BaseAddress
        {
            get { return "http://localhost/site/"; }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:\\DEV\\SeleniumTests");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }
    }
}

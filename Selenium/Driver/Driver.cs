namespace Selenium.Driver
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.IE;

    public static class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static void Initialize()
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            var browser = TestContexts.TestContexts.TestContexts.Browser;

            switch (browser.ToLower())
            {
                case "ie":
                    Instance = new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(), new InternetExplorerOptions());
                    break;
                case "chrome":
                    Instance = new ChromeDriver(ChromeDriverService.CreateDefaultService(), new ChromeOptions());
                    break;
                default:
                    Instance = new ChromeDriver(ChromeDriverService.CreateDefaultService(), new ChromeOptions());
                    break;
            }

            Debug.Assert(Instance != null, nameof(Instance) + " != null");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            LoggerSelenium.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void Close()
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            Instance.Close();

            LoggerSelenium.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
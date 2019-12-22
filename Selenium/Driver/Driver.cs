namespace Selenium.Driver
{
    using System;
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public static class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static void Initialize()
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            Instance = new ChromeDriver("C:\\DEV\\SeleniumTests");
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
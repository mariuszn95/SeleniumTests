namespace Selenium.Driver
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public static class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver("C:\\DEV\\SeleniumTests");
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Click(By locator)
        {
            FindElement(locator).Click();
        }

        public static void SendKeys(By locator, string enterValue)
        {
            FindElement(locator).SendKeys(enterValue);
        }

        public static string GetText(By locator)
        {
            return FindElement(locator).Text;
        }

        private static IWebElement FindElement(By locator)
        {
            return Instance.FindElement(locator);
        }
    }
}
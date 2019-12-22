namespace Selenium.Driver
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    public static class ElementHelpers
    {
        public static void Click(By locator)
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            FindElement(locator).Click();

            LoggerSelenium.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void Click(IWebElement element)
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            element.Click();

            LoggerSelenium.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static IWebElement FindElement(By locator)
        {
            LoggerSelenium.LogReturn(MethodBase.GetCurrentMethod().Name);

            return Driver.Instance.FindElement(locator);
        }

        public static string GetText(By locator)
        {
            LoggerSelenium.LogReturn(MethodBase.GetCurrentMethod().Name);

            return FindElement(locator).Text;
        }

        public static void SendKeys(By locator, string enterValue)
        {
            LoggerSelenium.LogStart(MethodBase.GetCurrentMethod().Name);

            FindElement(locator).SendKeys(enterValue);

            LoggerSelenium.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
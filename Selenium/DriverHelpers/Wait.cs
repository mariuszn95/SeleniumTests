namespace Selenium.DriverHelpers
{
    using System;

    using Logger.Logger;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public static class Wait
    {
        public static void Until(Func<IWebDriver, bool> condition)
        {
            LoggerSelenium.LogStart(System.Reflection.MethodBase.GetCurrentMethod().Name);

            var wait = new WebDriverWait(Driver.Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(condition);

            LoggerSelenium.LogEnd(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
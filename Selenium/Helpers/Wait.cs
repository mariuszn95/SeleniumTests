using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Helpers
{
    public class Wait
    {
        public static void Until(Func<IWebDriver, bool> condition)
        {
            var wait = new WebDriverWait(Driver.Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(condition);
        }
    }
}
namespace OlxFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchButton = By.CssSelector("#submit-searchmain");

        private static readonly By SearchInput = By.CssSelector("#headerSearch");

        internal static void ClickSearchButton()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            Driver.Click(SearchButton);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        internal static void EnterSearchValue(string searchValue)
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            Driver.SendKeys(SearchInput, searchValue);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
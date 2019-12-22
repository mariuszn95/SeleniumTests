namespace CeneoFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchButton = By.CssSelector(".search-icon");

        private static readonly By SearchInput = By.CssSelector("#form-head-search-q");

        internal static void ClickSearchButton()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            ElementHelpers.Click(SearchButton);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        internal static void EnterSearchValue(string searchValue)
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            ElementHelpers.SendKeys(SearchInput, searchValue);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
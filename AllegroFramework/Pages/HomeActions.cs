namespace AllegroFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By CloseRodoButton =
            By.XPath("//button[@data-analytics-interaction-value='closeIcon']");

        private static readonly By SearchButton = By.XPath("//button[@data-role='search-button']");

        private static readonly By SearchInput = By.XPath("//input[@data-role='search-input']");

        internal static void CloseRodo()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            Driver.Click(CloseRodoButton);

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

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
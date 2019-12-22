namespace AllegroFramework.Pages
{
    using System.Reflection;

    using Elements.Basic;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchInput = By.XPath("//input[@data-role='search-input']");

        private static Button CloseRodoButton => new Button(By.XPath("//button[@data-analytics-interaction-value='closeIcon']"));

        private static Button SearchButton => new Button(By.XPath("//button[@data-role='search-button']"));

        internal static void CloseRodo()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            CloseRodoButton.Click();

            LoggerActions.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        internal static void ClickSearchButton()
        {
            LoggerActions.LogStart(MethodBase.GetCurrentMethod().Name);

            SearchButton.Click();

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
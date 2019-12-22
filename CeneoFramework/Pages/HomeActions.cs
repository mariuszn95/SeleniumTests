namespace CeneoFramework.Pages
{
    using System.Reflection;

    using Elements.Basic;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchInput = By.CssSelector("#form-head-search-q");

        private static Button SearchButton => new Button(By.CssSelector(".search-icon"));

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
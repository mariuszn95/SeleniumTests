namespace CeneoFramework.Pages
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class HomeActions
    {
        private static readonly By SearchButton = By.CssSelector(".search-icon");

        private static readonly By SearchInput = By.CssSelector("#form-head-search-q");

        internal static void ClickSearchButton()
        {
            Driver.Click(SearchButton);
        }

        internal static void EnterSearchValue(string searchValue)
        {
            Driver.SendKeys(SearchInput, searchValue);
        }
    }
}
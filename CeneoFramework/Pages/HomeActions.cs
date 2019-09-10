using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Pages
{
    internal static class HomeActions
    {
        private static readonly By SearchInput = By.CssSelector("#form-head-search-q");
        private static readonly By SearchButton = By.CssSelector(".search-icon");

        internal static void EnterSearchValue(string searchValue)
        {
            Driver.SendKeys(SearchInput, searchValue);
        }

        internal static void ClickSearchButton()
        {
            Driver.Click(SearchButton);
        }
    }
}
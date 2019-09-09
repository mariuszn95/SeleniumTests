using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Pages
{
    internal class HomeActions
    {
        private static readonly By SearchInput = By.CssSelector("#form-head-search-q");
        private static readonly By SearchButton = By.CssSelector(".search-icon");

        internal static void EnterSearchValue(string searchValue)
        {
            Driver.SendKeys(SearchButton, searchValue);
        }

        internal static void ClickSearchButton()
        {
            Driver.Click(SearchButton);
        }
    }
}
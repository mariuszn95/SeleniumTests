using OpenQA.Selenium;
using Selenium.Driver;

namespace OlxFramework.Pages
{
    internal static class HomeActions
    {
        private static readonly By SearchInput = By.CssSelector("#headerSearch");
        private static readonly By SearchButton = By.CssSelector("#submit-searchmain");

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
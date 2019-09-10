using OpenQA.Selenium;
using Selenium.Driver;

namespace AllegroFramework.Pages
{
    internal static class HomeActions
    {
        private static readonly By SearchInput = By.XPath("//input[@data-role='search-input']");
        private static readonly By SearchButton = By.XPath("//button[@data-role='search-button']");

        private static readonly By CloseRodoButton =
            By.XPath("//button[@data-analytics-interaction-value='closeIcon']");

        internal static void EnterSearchValue(string searchValue)
        {
            Driver.SendKeys(SearchInput, searchValue);
        }

        internal static void ClickSearchButton()
        {
            Driver.Click(SearchButton);
        }

        public static void CloseRodo()
        {
            Driver.Click(CloseRodoButton);
        }
    }
}
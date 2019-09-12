namespace AllegroFramework.Pages
{
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
            Driver.Click(CloseRodoButton);
        }

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
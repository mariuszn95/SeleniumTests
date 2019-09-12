namespace CeneoFramework.Pages
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".cat-prod-row-name a");

        private static readonly By PricePenny = By.CssSelector(".price .penny");

        private static readonly By PriceValue = By.CssSelector(".price .value");

        internal static string GetFirstProductName()
        {
            return Driver.GetText(Name);
        }

        internal static string GetFirstProductPricePenny()
        {
            return Driver.GetText(PricePenny);
        }

        internal static string GetFirstProductPriceValue()
        {
            return Driver.GetText(PriceValue);
        }
    }
}
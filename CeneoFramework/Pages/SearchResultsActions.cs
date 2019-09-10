using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Pages
{
    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".cat-prod-row-name a");
        private static readonly By PriceValue = By.CssSelector(".price .value");
        private static readonly By PricePenny = By.CssSelector(".price .penny");

        internal static string GetFirstProductName()
        {
            return Driver.GetText(Name);
        }

        internal static string GetFirstProductPriceValue()
        {
            return Driver.GetText(PriceValue);
        }

        internal static string GetFirstProductPricePenny()
        {
            return Driver.GetText(PricePenny);
        }
    }
}
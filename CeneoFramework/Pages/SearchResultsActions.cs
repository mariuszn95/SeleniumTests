using OpenQA.Selenium;
using Selenium.Driver;

namespace CeneoFramework.Pages
{
    internal class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".cat-prod-row-name a");
        private static readonly By PriceValue = By.CssSelector(".price .value");
        private static readonly By PricePenny = By.CssSelector(".price .penny");

        internal static string GetFirstProductName()
        {
            return Driver.FindElement(Name).Text;
        }

        internal static string GetFirstProductPriceValue()
        {
            return Driver.FindElement(PriceValue).Text;
        }

        internal static string GetFirstProductPricePenny()
        {
            return Driver.FindElement(PricePenny).Text;
        }
    }
}
namespace CeneoFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".cat-prod-row-name a");

        private static readonly By PricePenny = By.CssSelector(".price .penny");

        private static readonly By PriceValue = By.CssSelector(".price .value");

        internal static string GetFirstProductName()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(Name);
        }

        internal static string GetFirstProductPricePenny()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(PricePenny);
        }

        internal static string GetFirstProductPriceValue()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(PriceValue);
        }
    }
}
namespace OlxFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".wrap .title-cell strong");

        private static readonly By PriceValue = By.CssSelector(".price strong");

        internal static string GetFirstProductName()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(Name);
        }

        internal static string GetFirstProductPriceValue()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(PriceValue);
        }
    }
}
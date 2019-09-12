namespace AllegroFramework.Pages
{
    using System;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".opbox-listing--base article h2 > a");

        private static readonly By PriceValue = By.CssSelector(".opbox-listing--base article div > span > span");

        internal static string GetFirstProductName()
        {
            return Driver.GetText(Name);
        }

        internal static string GetFirstProductPrice()
        {
            var priceValue = Driver.GetText(PriceValue);

            return priceValue;
        }

        internal static int GetFirstProductPriceValue()
        {
            var priceValue = GetFirstProductPrice();

            var intPrice = int.Parse(priceValue.Substring(0, priceValue.IndexOf(",", StringComparison.Ordinal)));

            return intPrice;
        }
    }
}
﻿namespace AllegroFramework.Pages
{
    using System;
    using System.Reflection;

    using Logger.Logger;

    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".opbox-listing h2 > a");

        private static readonly By PriceValue = By.CssSelector(".opbox-listing article div:first-child > span");

        internal static string GetFirstProductName()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            return ElementHelpers.GetText(Name);
        }

        internal static string GetFirstProductPrice()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            var priceValue = ElementHelpers.GetText(PriceValue);

            return priceValue;
        }

        internal static int GetFirstProductPriceValue()
        {
            LoggerActions.LogReturn(MethodBase.GetCurrentMethod().Name);

            var priceValue = GetFirstProductPrice();

            var intPrice = int.Parse(priceValue.Substring(0, priceValue.IndexOf(",", StringComparison.Ordinal)));

            return intPrice;
        }
    }
}
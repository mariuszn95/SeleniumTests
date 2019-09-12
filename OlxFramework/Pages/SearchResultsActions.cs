﻿namespace OlxFramework.Pages
{
    using OpenQA.Selenium;

    using Selenium.Driver;

    internal static class SearchResultsActions
    {
        private static readonly By Name = By.CssSelector(".wrap .title-cell strong");

        private static readonly By PriceValue = By.CssSelector(".price strong");

        internal static string GetFirstProductName()
        {
            return Driver.GetText(Name);
        }

        internal static string GetFirstProductPriceValue()
        {
            return Driver.GetText(PriceValue);
        }
    }
}
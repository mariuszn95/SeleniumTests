﻿using System;
using OlxFramework.Pages;

namespace OlxFramework.Helpers
{
    public static class Print
    {
        public static FirstProductInformation FirstProductInformation()
        {
            return new FirstProductInformation();
        }
    }

    public class FirstProductInformation
    {
        private string _name;
        private string _price;

        public FirstProductInformation Name()
        {
            _name = SearchResultsActions.GetFirstProductName();

            Console.Write($"Name: {_name}");

            return this;
        }

        public void WithPrice()
        {
            var priceValue = SearchResultsActions.GetFirstProductPriceValue();

            _price = $"{priceValue}";

            Console.WriteLine($", Price: {_price}");
        }
    }
}
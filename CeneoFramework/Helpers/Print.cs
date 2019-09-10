using System;
using CeneoFramework.Pages;

namespace CeneoFramework.Helpers
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
            var pricePenny = SearchResultsActions.GetFirstProductPricePenny();

            _price = $"{priceValue}{pricePenny}";

            Console.WriteLine($", Price: {_price}");
        }
    }
}
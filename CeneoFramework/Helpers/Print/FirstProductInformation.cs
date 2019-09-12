namespace CeneoFramework.Helpers.Print
{
    using System;

    using CeneoFramework.Pages;

    public class FirstProductInformation
    {
        private string name;

        private string price;

        public FirstProductInformation Name()
        {
            this.name = SearchResultsActions.GetFirstProductName();

            Console.Write($"Name: {this.name}");

            return this;
        }

        public void WithPrice()
        {
            var priceValue = SearchResultsActions.GetFirstProductPriceValue();
            var pricePenny = SearchResultsActions.GetFirstProductPricePenny();

            this.price = $"{priceValue}{pricePenny} zł";

            Console.WriteLine($", Price: {this.price}");
        }
    }
}
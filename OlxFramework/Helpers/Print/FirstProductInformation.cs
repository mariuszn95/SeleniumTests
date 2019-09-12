namespace OlxFramework.Helpers.Print
{
    using System;

    using OlxFramework.Pages;

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

            this.price = $"{priceValue}";

            Console.WriteLine($", Price: {this.price}");
        }
    }
}
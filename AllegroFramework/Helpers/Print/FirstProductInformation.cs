namespace AllegroFramework.Helpers.Print
{
    using System;

    using AllegroFramework.Pages;

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
            var firstProductPrice = SearchResultsActions.GetFirstProductPrice();

            this.price = $"{firstProductPrice}";

            Console.WriteLine($", Price: {this.price}");
        }
    }
}
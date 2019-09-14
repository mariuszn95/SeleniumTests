namespace AllegroFramework.Helpers.Print
{
    using System;
    using System.Reflection;

    using AllegroFramework.Pages;

    using Logger.Logger;

    public class FirstProductInformation
    {
        private string name;

        private string price;

        public FirstProductInformation Name()
        {
            LoggerPage.LogReturn(MethodBase.GetCurrentMethod().Name);

            this.name = SearchResultsActions.GetFirstProductName();

            Console.Write($"Name: {this.name}");

            return this;
        }

        public void WithPrice()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            var firstProductPrice = SearchResultsActions.GetFirstProductPrice();

            this.price = $"{firstProductPrice}";

            Console.WriteLine($", Price: {this.price}");

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
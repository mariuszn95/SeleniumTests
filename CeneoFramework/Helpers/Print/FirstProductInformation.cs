namespace CeneoFramework.Helpers.Print
{
    using System;
    using System.Reflection;

    using CeneoFramework.Pages;

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

            var priceValue = SearchResultsActions.GetFirstProductPriceValue();
            var pricePenny = SearchResultsActions.GetFirstProductPricePenny();

            this.price = $"{priceValue}{pricePenny} zł";

            Console.WriteLine($", Price: {this.price}");

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
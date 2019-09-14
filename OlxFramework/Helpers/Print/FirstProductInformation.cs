namespace OlxFramework.Helpers.Print
{
    using System.Reflection;

    using Logger.Logger;

    using OlxFramework.Pages;

    public class FirstProductInformation
    {
        private string name;

        private string price;

        public FirstProductInformation Name()
        {
            LoggerPage.LogReturn(MethodBase.GetCurrentMethod().Name);

            this.name = SearchResultsActions.GetFirstProductName();

            Logger.Log($"Name: {this.name}");

            return this;
        }

        public void WithPrice()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            var priceValue = SearchResultsActions.GetFirstProductPriceValue();

            this.price = $"{priceValue}";

            Logger.Log($", Price: {this.price}");

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
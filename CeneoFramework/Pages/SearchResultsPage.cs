namespace CeneoFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    public static class SearchResultsPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
                LoggerPage.LogReturn(MethodBase.GetCurrentMethod().Name);

                var priceValue = SearchResultsActions.GetFirstProductPriceValue();

                var intPrice = int.Parse(priceValue);

                return intPrice;
            }
        }
    }
}
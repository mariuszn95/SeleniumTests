namespace OlxFramework.Pages
{
    using System;
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

                int intPrice;

                try
                {
                    intPrice = int.Parse(priceValue.Substring(0, priceValue.IndexOf(" ", StringComparison.Ordinal)));
                }
                catch (Exception)
                {
                    intPrice = int.Parse(priceValue.Substring(0, priceValue.IndexOf(",", StringComparison.Ordinal)));
                }

                return intPrice;
            }
        }
    }
}
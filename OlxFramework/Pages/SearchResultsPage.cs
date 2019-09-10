using System;

namespace OlxFramework.Pages
{
    public static class SearchResultsPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
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
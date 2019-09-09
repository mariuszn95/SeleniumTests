using System;

namespace OlxFramework.Pages
{
    public class SearchResultsPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
                var priceValue = SearchResultsActions.GetFirstProductPriceValue();

                var intPrice = int.Parse(priceValue.Substring(0, priceValue.IndexOf(" ", StringComparison.Ordinal)));

                return intPrice;
            }
        }
    }
}
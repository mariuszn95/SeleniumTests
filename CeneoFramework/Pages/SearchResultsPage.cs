namespace CeneoFramework.Pages
{
    public class SearchResultsPage
    {
        public static int GetThePriceOfTheFirstProduct
        {
            get
            {
                var priceValue = SearchResultsActions.GetFirstProductPriceValue();

                var intPrice = int.Parse(priceValue);

                return intPrice;
            }
        }
    }
}
namespace AllegroFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    public static class SearchResultsPage
    {
        public static int GetThePriceValueOfTheFirstProduct
        {
            get
            {
                LoggerPage.LogReturn(MethodBase.GetCurrentMethod().Name);

                return SearchResultsActions.GetFirstProductPriceValue();
            }
        }
    }
}
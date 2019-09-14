namespace CeneoFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    public static class HomePage
    {
        public static void Search(string searchValue)
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
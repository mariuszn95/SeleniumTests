namespace AllegroFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    public static class HomePage
    {
        public static void CloseRodo()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            HomeActions.CloseRodo();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void Search(string searchValue)
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
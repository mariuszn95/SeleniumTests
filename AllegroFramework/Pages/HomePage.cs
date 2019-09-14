namespace AllegroFramework.Pages
{
    using System.Reflection;

    using Logger.Logger;

    using Selenium.DriverHelpers;

    using static TestContexts.TestContexts.TestContexts;

    public static class HomePage
    {
        public static void CloseRodo()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            HomeActions.CloseRodo();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void GoTo()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            Navigate.ToUrl(GetBaseAddress());
            Wait.Until(d => d.Title.Contains("Allegro"));

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
using Selenium.DriverHelpers;
using static TestContexts.TestContexts.TestContexts;

namespace AllegroFramework.Pages
{
    public static class HomePage
    {
        public static void GoTo()
        {
            Navigate.ToUrl(GetBaseAddress());
            Wait.Until(d => d.Title.Contains("Allegro"));
        }

        public static void Search(string searchValue)
        {
            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();
        }

        public static void CloseRodo()
        {
            HomeActions.CloseRodo();
        }
    }
}
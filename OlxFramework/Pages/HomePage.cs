using Selenium.DriverHelpers;
using Selenium.TestContexts;

namespace OlxFramework.Pages
{
    public static class HomePage
    {
        public static void GoTo()
        {
            Navigate.ToUrl(TestContexts.GetBaseAddress());
            Wait.Until(d => d.Title.Contains("OLX"));
        }

        public static void Search(string searchValue)
        {
            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();
        }
    }
}
using Selenium.DriverHelpers;
using static TestContexts.TestContexts.TestContexts;

namespace CeneoFramework.Pages
{
    public static class HomePage
    {
        public static void GoTo()
        {
            Navigate.ToUrl(GetBaseAddress());
            Wait.Until(d => d.Title.Contains("Ceneo"));
        }

        public static void Search(string searchValue)
        {
            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();
        }
    }
}
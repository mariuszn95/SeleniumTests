using Selenium.Helpers;
using Selenium.TestContexts;

namespace OlxFramework.Pages
{
    public class HomePage
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
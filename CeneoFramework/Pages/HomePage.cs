using Selenium.Helpers;
using Selenium.TestContexts;

namespace CeneoFramework.Pages
{
    public class HomePage
    {
        public static void GoTo()
        {
            Navigate.ToUrl(TestContexts.GetBaseAddress());
            Wait.Until(d => d.Title.Contains("Ceneo"));
        }

        public static void Search(string searchValue)
        {
            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();
        }
    }
}
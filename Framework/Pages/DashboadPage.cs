using Framework.Selenium;

namespace Framework.Pages
{
    public static class DashboadPage
    {
        private static string PageTitle = "Dashboard";

        public static bool IsAt()
        {
            if (Driver.Title.Contains(PageTitle))
                return true;
            return false;
        }
    }
}

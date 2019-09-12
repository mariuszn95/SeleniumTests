namespace WordPressFramework.Pages
{
    using WordPressFramework.Selenium;

    public static class DashboadPage
    {
        private static readonly string PageTitle = "Dashboard";

        public static bool IsAt()
        {
            if (Driver.Title.Contains(PageTitle))
            {
                return true;
            }

            return false;
        }
    }
}
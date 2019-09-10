﻿using Selenium.DriverHelpers;
using static TestContexts.TestContexts.TestContexts;

namespace OlxFramework.Pages
{
    public static class HomePage
    {
        public static void GoTo()
        {
            Navigate.ToUrl(GetBaseAddress());
            Wait.Until(d => d.Title.Contains("OLX"));
        }

        public static void Search(string searchValue)
        {
            HomeActions.EnterSearchValue(searchValue);
            HomeActions.ClickSearchButton();
        }
    }
}
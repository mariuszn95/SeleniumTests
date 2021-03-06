﻿namespace SetUpFramework.TestFixtures
{
    using System.Reflection;

    using ErrorMessages.ErrorMessages;

    using Logger.Logger;

    using Selenium.Driver;
    using Selenium.DriverHelpers;

    using static TestContexts.TestContexts.TestContexts;

    public static class BaseTestFixture
    {
        public static void CleanAndCloseWebsite()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            ErrorMessages.VerifyAndClearMessages();
            Manage.ClearCookies();
            Driver.Close();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void OpenService()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            Driver.Initialize();
            Navigate.ToUrl(BaseAddress);
            Wait.Until(d => d.Title.Contains(WebsiteName));

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
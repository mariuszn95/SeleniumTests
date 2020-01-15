namespace Selenium.DriverHelpers
{
    using Logger.Logger;

    public static class Manage
    {
        public static void ClearCookies()
        {
            LoggerSelenium.LogStart(System.Reflection.MethodBase.GetCurrentMethod().Name);

            Driver.Driver.Instance.Manage().Cookies.DeleteAllCookies();

            LoggerSelenium.LogStart(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
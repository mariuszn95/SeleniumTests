namespace Selenium.DriverHelpers
{
    using Logger.Logger;

    public static class Navigate
    {
        public static void ToUrl(string url)
        {
            LoggerSelenium.LogStart(System.Reflection.MethodBase.GetCurrentMethod().Name);

            Driver.Driver.Instance.Navigate().GoToUrl(url);

            LoggerSelenium.LogStart(System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}
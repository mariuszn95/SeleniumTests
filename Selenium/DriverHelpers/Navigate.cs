namespace Selenium.DriverHelpers
{
    public static class Navigate
    {
        public static void ToUrl(string url)
        {
            Driver.Driver.Instance.Navigate().GoToUrl(url);
        }
    }
}
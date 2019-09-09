namespace Selenium.Helpers
{
    public class Navigate
    {
        public static void ToUrl(string url)
        {
            Driver.Driver.Instance.Navigate().GoToUrl(url);
        }
    }
}
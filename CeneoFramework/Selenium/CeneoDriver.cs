using Selenium.Driver;

namespace CeneoFramework.Selenium
{
    public static class CeneoDriver
    {
        public static void Initialize()
        {
            Driver.Initialize();
        }

        public static void Close()
        {
            Driver.Close();
        }
    }
}
using Selenium.Driver;

namespace CeneoFramework.Selenium
{
    public class CeneoDriver
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
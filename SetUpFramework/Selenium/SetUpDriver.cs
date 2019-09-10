using Selenium.Driver;

namespace SetUpFramework.Selenium
{
    public static class SetUpDriver
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
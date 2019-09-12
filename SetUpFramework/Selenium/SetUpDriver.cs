namespace SetUpFramework.Selenium
{
    using global::Selenium.Driver;

    public static class SetUpDriver
    {
        public static void Close()
        {
            Driver.Close();
        }

        public static void Initialize()
        {
            Driver.Initialize();
        }
    }
}
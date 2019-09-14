namespace SetUpFramework.Selenium
{
    using System.Reflection;

    using Logger.Logger;

    public static class SetUpDriver
    {
        public static void Close()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            global::Selenium.Driver.Driver.Close();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }

        public static void Initialize()
        {
            LoggerPage.LogStart(MethodBase.GetCurrentMethod().Name);

            global::Selenium.Driver.Driver.Initialize();

            LoggerPage.LogEnd(MethodBase.GetCurrentMethod().Name);
        }
    }
}
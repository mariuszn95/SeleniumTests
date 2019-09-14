namespace OlxFramework.Helpers.Print
{
    using System.Reflection;

    using Logger.Logger;

    public static class Print
    {
        public static FirstProductInformation FirstProductInformation()
        {
            LoggerPage.LogReturn(MethodBase.GetCurrentMethod().Name);

            return new FirstProductInformation();
        }
    }
}
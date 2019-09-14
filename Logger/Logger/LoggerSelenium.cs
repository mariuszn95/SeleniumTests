namespace Logger.Logger
{
    public class LoggerSelenium
    {
        private static string dashes = "----- ----- ----- ";

        public static void LogStart(string message)
        {
            Logger.InternalLog($"{dashes}Start - {message}");
        }

        public static void LogEnd(string message)
        {
            Logger.InternalLog($"{dashes}End - {message}");
        }

        public static void LogReturn(string message)
        {
            Logger.InternalLog($"{dashes}Return - {message}");
        }
    }
}
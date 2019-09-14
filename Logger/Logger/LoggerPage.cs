namespace Logger.Logger
{
    public class LoggerPage
    {
        private static string dashes = "----- ";

        public static void LogStart(string message)
        {
            Logger.Log($"{dashes}Start - {message}");
        }

        public static void LogEnd(string message)
        {
            Logger.Log($"{dashes}End - {message}");
        }

        public static void LogReturn(string message)
        {
            Logger.Log($"{dashes}Return - {message}");
        }
    }
}
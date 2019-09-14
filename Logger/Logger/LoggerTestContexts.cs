namespace Logger.Logger
{
    public class LoggerTestContexts
    {
        private static string dashes = "----- TestContexts ----- ";

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
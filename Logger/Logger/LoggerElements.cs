namespace Logger.Logger
{
    public class LoggerElements
    {
        private static readonly string Dashes = "----- ----- ----- ";

        public static void LogStart(string message)
        {
            Logger.InternalLog($"{Dashes}Start - {message}");
        }

        public static void LogEnd(string message)
        {
            Logger.InternalLog($"{Dashes}End - {message}");
        }

        public static void LogReturn(string message)
        {
            Logger.InternalLog($"{Dashes}Return - {message}");
        }
    }
}
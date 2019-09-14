namespace Logger.Logger
{
    public class LoggerError
    {
        public static void Log(string message)
        {
            Logger.InternalLog("----- Error ----- " + message);
        }
    }
}
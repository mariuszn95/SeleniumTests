namespace Logger.Logger
{
    public class LoggerError
    {
        public static void Log(string message)
        {
            Logger.Log("----- Error ----- " + message);
        }
    }
}
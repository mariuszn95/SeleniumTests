namespace Logger.Logger
{
    public class LoggerScreenshot
    {
        public static void Log(string message)
        {
            Logger.InternalLog("----- Screenshot ----- " + message);
        }
    }
}
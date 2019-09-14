namespace Logger.Logger
{
    using System;

    public static class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} : ***** {message}");
        }

        internal static void InternalLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}
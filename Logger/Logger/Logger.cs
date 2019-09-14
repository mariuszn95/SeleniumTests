namespace Logger.Logger
{
    using System;

    internal static class Logger
    {
        internal static void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}
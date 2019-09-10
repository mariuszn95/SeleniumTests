using System;

namespace Logger.Logger
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}
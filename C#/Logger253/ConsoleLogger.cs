using System;

namespace Logger
{
    public class ConsoleLogger
    {
        public static void Log(string msg)
        {
            Console.WriteLine($"{DateTime.Now} {msg}");
        }
    }
}
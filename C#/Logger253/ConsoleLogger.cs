using Logger.Core;
using System;

namespace Logger
{
    public class ConsoleLogger : BaseLogger
    {
        protected override void SubClassLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
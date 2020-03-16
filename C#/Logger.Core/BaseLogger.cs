using System;

namespace Logger.Core
{
    public abstract class BaseLogger : ILogger
    {
        protected string FormatOutput(string msg)
        {
            return $"{DateTime.Now}: {msg}\n";
        }
        protected abstract void SubClassLog(string msg);
        public void Log(string msg)
        {
            SubClassLog(FormatOutput(msg));
        }
    }
}
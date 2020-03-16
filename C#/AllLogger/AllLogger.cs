using Logger.Core;

namespace Logger
{
    public class AllLogger : BaseLogger
    {
        string fileName;
        public AllLogger(string fileName)
        {
            this.fileName = fileName;
        }

        protected override void SubClassLog(string msg)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(msg);

            ILogger fileLogger = new FileLogger(fileName);
            fileLogger.Log(msg);
        }
    }
}
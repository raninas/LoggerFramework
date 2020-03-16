using Logger.Core;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        string fileName;
        public FileLogger(string fileName)
        {
            this.fileName = fileName;
        }
        protected override void SubClassLog(string msg)
        {
            File.AppendAllText(fileName, msg);
        }
    }
}
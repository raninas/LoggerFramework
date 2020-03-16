using Logger.Core;
using System.Threading;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger allLogger = new AllLogger(".\\log.txt");
            allLogger.Log("Program Started");
            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
            allLogger.Log("Program Ended");
        }
    }
}
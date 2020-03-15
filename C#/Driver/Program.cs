using Logger253;
using System.Threading;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Log("Program Started", ".\\log.txt");

            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds

            Log("Program Ended", ".\\log.txt");
        }
        static void Log(string msg, string fileName)
        {
            ConsoleLogger.Log(msg);
            FileLogger.Log(fileName, msg);
        }
    }
}
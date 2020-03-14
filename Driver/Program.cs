using System;
using System.Threading;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Log("Program Started");
            Thread.Sleep(3000); //Simulating work by having the program sleep for 3 seconds
            Logger.Log("Program Ended");
        }
    }
}
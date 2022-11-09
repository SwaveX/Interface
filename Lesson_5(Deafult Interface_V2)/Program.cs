using System;

namespace Lesson_5_Deafult_Interface_V2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(LogLevel.Debug, "Event");
            consoleLogger.Log(LogLevel.Warning, "Warning");
            consoleLogger.Log(LogLevel.Error, "Error");
            consoleLogger.LogFatal("Execution");
        }
    }
}

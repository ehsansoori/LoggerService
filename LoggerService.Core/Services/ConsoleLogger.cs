using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Core.Services
{
    /// <summary>
    /// Logs messages to the console output.
    /// </summary>
    public class ConsoleLogger:ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine($"[ConsoleLogger] {message}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Core.Services
{
    /// <summary>
    /// Logs messages to a file on disk.
    /// </summary>
    public class FileLogger: ILogger
    {
        private readonly string _filePath;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        public void Log(string message)
        {
            try
            {
                System.IO.File.AppendAllText(_filePath, $"[FileLogger] {message}{Environment.NewLine}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log to file: {ex.Message}");
            }
        }
    }
}

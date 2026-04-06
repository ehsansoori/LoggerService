using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Core.Services
{
    /// <summary>
    /// Logs messages to multiple logger implementations.
    /// </summary>
    public class Multilogger : ILogger
        
    {
        private readonly IEnumerable<ILogger> _loggers;
        public Multilogger(IEnumerable<ILogger> loggers)
        {
            this._loggers = loggers;
        }
        public void Log(string message)
        {
            // Send the same log message to all registered loggers
            foreach (var logger in _loggers)
            {
                logger.Log(message);
            }
        }
    }
}

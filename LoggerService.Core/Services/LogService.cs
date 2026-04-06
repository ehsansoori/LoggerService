using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Core.Services
{
    /// <summary>
    /// Provides a high-level logging service that delegates logging operations
    /// to an injected ILogger implementation.
    /// This class demonstrates the use of Dependency Injection to decouple
    /// the logging logic from concrete implementations.
    /// </summary>
    public class LogService
    {
        private readonly ILogger _logger;
        public LogService(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessLog(string message)
        {
            // Delegate the logging task to the injected logger
            _logger.Log(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Core.Services
{
    /// <summary>
    /// Defines a contract for logging messages.
    /// </summary>
    public interface ILogger
    {
        void Log(string message);
    }
}

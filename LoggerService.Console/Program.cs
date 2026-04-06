// See https://aka.ms/new-console-template for more information



using LoggerService.Core.Services;
using Microsoft.VisualBasic;
using System.Collections.Generic;

var loggers = new List<ILogger>
{
    new ConsoleLogger(),
    new FileLogger("C://MyLogs//log.txt")
};  

ILogger logger = new Multilogger(loggers);
var service = new LogService(logger);
service.ProcessLog(string.Format("Log at {0}", DateAndTime.Now));
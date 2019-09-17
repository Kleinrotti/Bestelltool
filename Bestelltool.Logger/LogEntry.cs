using System;

namespace Bestelltool.Logger
{
     public struct LogEntry
     {
          public LogType Type { get; set; }
          public DateTime Time { get; set; }
          public string Message { get; set; }
          public Exception Exception { get; set; }

          public LogEntry(LogType type, DateTime time, string message)
          {
               Type = type;
               Time = time;
               Message = message;
               Exception = null;
          }

          public LogEntry(LogType type, DateTime time, string message, Exception exception)
          {
               Type = type;
               Time = time;
               Message = message;
               Exception = exception;
          }
     }
}
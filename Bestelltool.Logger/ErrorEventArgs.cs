using System;
namespace Bestelltool.Logger
{
     public class ErrorEventArgs : EventArgs
     {
          private readonly LogEntry _entry;
          public LogEntry Entry { get => _entry; }

          public ErrorEventArgs(string errorMessage)
          {
               _entry = new LogEntry(LogType.Error,DateTime.Now, errorMessage);
          }
     }
}
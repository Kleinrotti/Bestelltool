using Bestelltool.Structs;
using System.Collections.Generic;

namespace Bestelltool.Interfaces
{
    public interface ILog
    {
        string Destination { get; set; }
        bool InsertTime { get; set; }

        void Error(string message);

        void Info(string message);

        void Warning(string message);

        List<LogEntry> GetLog(string file);
    }
}
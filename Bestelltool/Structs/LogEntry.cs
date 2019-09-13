using System;

namespace Bestelltool.Structs
{
    public struct LogEntry
    {
        public LogType Type { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
    }
}
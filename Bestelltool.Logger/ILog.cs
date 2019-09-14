using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Bestelltool.Logger
{
    public interface ILog
    {
        void Error(string message);

        void Info(string message);

        void Warning(string message);

        JObject GetCurrentLogConfig { get; }

        List<LogEntry> GetLog();
    }
}
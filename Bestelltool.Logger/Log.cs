using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Bestelltool.Logger
{
    public class Log : FileOperation, ILog
    {
        public static string Destination { get; set; }
        public static bool InsertTime { get; set; }

        public JObject GetCurrentLogConfig { get => CurrentLogConfig; }

        protected static JObject CurrentLogConfig;

        protected static char Seperator = ':';

        public Log()
        {
            InsertTime = true;
            Destination = "log.txt";
        }
        public Log(string path, bool insertTime)
        {
            Destination = path;
            InsertTime = insertTime;
        }

        /// <summary>
        /// Writing an error message
        /// </summary>
        /// <param name="message"></param>
        public virtual void Error(string message)
        {
            var v = DateTime.Now.ToString() + Seperator + LogType.Error.ToString() + Seperator + message;
            _ = WriteFile(Destination, v);
        }

        /// <summary>
        /// Writing an info message
        /// </summary>
        /// <param name="message"></param>
        public virtual void Info(string message)
        {
            var v = DateTime.Now.ToString() + Seperator + LogType.Info.ToString() + Seperator + message;
            _ = WriteFile(Destination, v);
        }

        /// <summary>
        /// Writing a warning message
        /// </summary>
        /// <param name="message"></param>
        public virtual void Warning(string message)
        {
            var v = DateTime.Now.ToString() + Seperator + LogType.Warning.ToString() + Seperator + message;
            _ = WriteFile(Destination, v);
        }

        /// <summary>
        /// Get the complete log
        /// </summary>
        /// <returns></returns>
        public virtual List<LogEntry> GetLog()
        {
            var logEntries = new List<LogEntry>();
            ReadFile(Destination);
            var content = FileContent;
            foreach(string s in content)
            {
                var split = s.Split(Seperator);
                var entry = new LogEntry
                {
                    Time = Convert.ToDateTime(split[0]),
                    Type = (LogType)Enum.Parse(typeof(LogType), split[1]),
                    Message = split[2]
                };
                logEntries.Add(entry);
            }
            return logEntries;
        }

        protected void GetConfig()
        {
            string content = null;
            ReadFile(ref content,Destination);
            CurrentLogConfig = JObject.Parse(content);
        }
    }
}
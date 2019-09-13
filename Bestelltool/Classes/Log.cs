using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bestelltool.Classes;
using Bestelltool.Interfaces;
using Bestelltool.Structs;

namespace Bestelltool
{
    internal class Log : FileOperation, ILog
    {
        public string Destination { get; set; }
        public bool InsertTime { get; set; }

        protected char Seperator = ':';
        public Log(string destination, bool insertTime)
        {
            Destination = destination;
            InsertTime = insertTime;
        }

        public virtual void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Info(string message)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Warning(string message)
        {
            throw new System.NotImplementedException();
        }

        protected override Task WriteFile(string path, string context)
        {

            return base.WriteFile(path, context);
        }

        public List<LogEntry> GetLog(string file)
        {
            var logEntries = new List<LogEntry>();
            ReadFile(file);
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
    }
}
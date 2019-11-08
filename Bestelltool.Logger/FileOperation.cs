using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bestelltool.Logger
{
    public class FileOperation
    {
        /// <summary>
        /// Contains readed Lines from file
        /// </summary>
        public List<string> FileContent { get; set; } = new List<string>();

        /// <summary>
        /// Reading a file and saving it in FileContent
        /// </summary>
        /// <param name="path"></param>
        protected void ReadFile(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                WaitFileReady(path);
                using (StreamReader r = new StreamReader(fs))
                {
                    while (!r.EndOfStream)
                    {
                        FileContent.Add(r.ReadLine());
                    }
                }
            }
        }

        /// <summary>
        /// Reading a file and storing content in the reference
        /// </summary>
        /// <param name="content"></param>
        /// <param name="path"></param>
        protected virtual void ReadFile(ref string content, string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                WaitFileReady(path);
                using (StreamReader r = new StreamReader(fs))
                {
                    content = r.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Write a string asynchronous to a file followed by a new line
        /// </summary>
        /// <param name="path"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        protected virtual async Task WriteFile(string path, string context)
        {
            WaitFileReady(path);
            using (StreamWriter w = File.AppendText(path))
            {
                await w.WriteLineAsync(context);
            }
        }

        /// <summary>
        /// Remove a string from a file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="context"></param>
        protected void Remove(string path, string context)
        {
            FileContent.Remove(context);
            WaitFileReady(path);
            using (StreamWriter w = new StreamWriter(path))
            {
                foreach (var v in FileContent)
                {
                    w.WriteLine(v);
                }
            }
        }

        private bool WaitFileReady(string path)
        {
            try
            {
                using (FileStream inputStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (inputStream.Length > 0)
                            return true;
                        else
                            Task.Delay(300);
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
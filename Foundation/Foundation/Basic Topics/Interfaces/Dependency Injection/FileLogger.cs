using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces.Dependency_Injection
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "INFO");
        }

        public void LogInfo(string message)
        {
            Log(message, "ERROR");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}

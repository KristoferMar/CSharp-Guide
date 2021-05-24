using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Interfaces.Dependency_Injection
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}

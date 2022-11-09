﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Deafult_Interface_V2_
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
        void LogFatal(string messege)
        {
            Log(LogLevel.Fatal, messege);
        }
    }
}

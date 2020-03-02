using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Webinar.Models.Utils
{
    public class MyLoggerProvider : ILoggerProvider
    {
        
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose() { }

        private class MyLogger : ILogger
        {
            private readonly object obj = new object();
            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId,
                    TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
               // lock (obj)
                {

                   // File.AppendAllText("DatabaseLog.txt", formatter(state, exception));
                  //  Console.WriteLine(formatter(state, exception));
                }
            }
        }
    }
}

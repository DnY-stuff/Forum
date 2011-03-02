using System;

namespace DnY.Forum.Infrastructure.Log
{
    public interface ILog
    {
        bool IsTraceEnabled { get; }
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }

        void Trace(object message);
        void Trace(string format, params object[] args);
        void Trace(string message, Exception t);

        void Debug(object message);
        void Debug(string format, params object[] args);
        void Debug(string message, Exception t);

        void Info(object message);
        void Info(string format, params object[] args);
        void Info(string message, Exception t);

        void Warn(object message);
        void Warn(string format, params object[] args);
        void Warn(string message, Exception t);

        void Error(object message);
        void Error(string format, params object[] args);
        void Error(string message, Exception t);

        void Fatal(object message);
        void Fatal(string format, params object[] args);
        void Fatal(string message, Exception t);
    }
}
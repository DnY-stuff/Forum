using System;
using NLog;

namespace DnY.Forum.Infrastructure.Log
{
    public class NLogLoggerProxy : ILog
    {
        private readonly Logger _NLoglogger;

        private NLogLoggerProxy(Logger nLoglogger)
        {
            _NLoglogger = nLoglogger;
        }

        #region << Implementation of ILog >>

        public bool IsDebugEnabled
        {
            get { return _NLoglogger.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _NLoglogger.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _NLoglogger.IsWarnEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _NLoglogger.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _NLoglogger.IsFatalEnabled; }
        }

        public void Debug(object message)
        {
            _NLoglogger.Debug(message);
        }

        public void Info(object message)
        {
            _NLoglogger.Info(message);
        }

        public void Warn(object message)
        {
            _NLoglogger.Warn(message);
        }

        public void Error(object message)
        {
            _NLoglogger.Error(message);
        }

        public void Fatal(object message)
        {
            _NLoglogger.Fatal(message);
        }

        public void Debug(string format, params object[] args)
        {
            _NLoglogger.Debug(format, args);
        }

        public void Info(string format, params object[] args)
        {
            _NLoglogger.Info(format, args);
        }

        public void Warn(string format, params object[] args)
        {
            _NLoglogger.Warn(format, args);
        }

        public void Error(string format, params object[] args)
        {
            _NLoglogger.Error(format, args);
        }

        public void Fatal(string format, params object[] args)
        {
            _NLoglogger.Fatal(format, args);
        }

        public void Debug(object message, Exception t)
        {
            _NLoglogger.DebugException(message.ToString(), t);
        }

        public void Info(object message, Exception t)
        {
            _NLoglogger.InfoException(message.ToString(), t);
        }

        public void Warn(object message, Exception t)
        {
            _NLoglogger.WarnException(message.ToString(), t);
        }

        public void Error(object message, Exception t)
        {
            _NLoglogger.ErrorException(message.ToString(), t);
        }

        public void Fatal(object message, Exception t)
        {
            _NLoglogger.FatalException(message.ToString(), t);
        }

        #endregion

        public static ILog GetLogger(string loggerName)
        {
            return new NLogLoggerProxy(LogManager.GetLogger(loggerName));
        }

        public static ILog GetCurrentClassLogger()
        {
            return new NLogLoggerProxy(LogManager.GetCurrentClassLogger());
        }

        public static ILog GetCurrentClassLogger(Type loggerType)
        {
            return new NLogLoggerProxy(LogManager.GetCurrentClassLogger(loggerType));
        }
    }
}
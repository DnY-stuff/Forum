using System;
using Common.Logging;

namespace DnY.Forum.Infrastructure.Log
{
    public class CommonLoggingLoggerProxy : ILog
    {
        private readonly Common.Logging.ILog _commonLogginLogger;

        private CommonLoggingLoggerProxy(Common.Logging.ILog logger)
        {
            _commonLogginLogger = logger;
        }

        #region << Implementation of ILog >>

        public bool IsTraceEnabled
        {
            get { return _commonLogginLogger.IsTraceEnabled; }
        }

        public bool IsDebugEnabled
        {
            get { return _commonLogginLogger.IsDebugEnabled; }
        }

        public bool IsInfoEnabled
        {
            get { return _commonLogginLogger.IsInfoEnabled; }
        }

        public bool IsWarnEnabled
        {
            get { return _commonLogginLogger.IsWarnEnabled; }
        }

        public bool IsErrorEnabled
        {
            get { return _commonLogginLogger.IsErrorEnabled; }
        }

        public bool IsFatalEnabled
        {
            get { return _commonLogginLogger.IsFatalEnabled; }
        }

        public void Trace(object message)
        {
            throw new NotImplementedException();
        }

        public void Debug(object message)
        {
            _commonLogginLogger.Debug(message);
        }

        public void Info(object message)
        {
            _commonLogginLogger.Info(message);
        }

        public void Warn(object message)
        {
            _commonLogginLogger.Warn(message);
        }

        public void Error(object message)
        {
            _commonLogginLogger.Error(message);
        }

        public void Fatal(object message)
        {
            _commonLogginLogger.Fatal(message);
        }

        public void Trace(string format, params object[] args)
        {
            _commonLogginLogger.TraceFormat(format, args);
        }

        public void Debug(string format, params object[] args)
        {
            _commonLogginLogger.DebugFormat(format, args);
        }

        public void Info(string format, params object[] args)
        {
            _commonLogginLogger.InfoFormat(format, args);
        }

        public void Warn(string format, params object[] args)
        {
            _commonLogginLogger.WarnFormat(format, args);
        }

        public void Error(string format, params object[] args)
        {
            _commonLogginLogger.ErrorFormat(format, args);
        }

        public void Fatal(string format, params object[] args)
        {
            _commonLogginLogger.FatalFormat(format, args);
        }

        public void Trace(string message, Exception t)
        {
            _commonLogginLogger.Trace(message.ToString(), t);
        }

        public void Debug(string message, Exception t)
        {
            _commonLogginLogger.Debug(message.ToString(), t);
        }

        public void Info(string message, Exception t)
        {
            _commonLogginLogger.Info(message.ToString(), t);
        }

        public void Warn(string message, Exception t)
        {
            _commonLogginLogger.Warn(message.ToString(), t);
        }

        public void Error(string message, Exception t)
        {
            _commonLogginLogger.Error(message.ToString(), t);
        }

        public void Fatal(string message, Exception t)
        {
            _commonLogginLogger.Fatal(message.ToString(), t);
        }

        #endregion

        public static ILog GetLogger(string loggerName)
        {
            return new CommonLoggingLoggerProxy(LogManager.GetLogger(loggerName));
        }

        public static ILog GetLogger(Type type)
        {
            return new CommonLoggingLoggerProxy(LogManager.GetLogger(type));
        }
    }
}
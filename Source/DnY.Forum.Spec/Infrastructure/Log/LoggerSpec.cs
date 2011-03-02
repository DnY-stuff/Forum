using System;

namespace DnY.Forum.Infrastructure.Log
{
    using Machine.Specifications;
    using It=Machine.Specifications.It;

    [Subject(typeof(LogFactory), "create a logger for context of specification"), Tags("Infrastructure.Log")]
    public class when_given_a_log_factory
    {
        Because of = () => logger = LogFactory.GetSpecificationLogger();

        [Ignore("NOTE : Moq���� Static Mocking�� �Ұ��ϴ�.")]
        It should_call_getlogger_of_proxy;
        It should_return_a_logger = () => logger.ShouldNotBeNull();

        private static ILog logger;
    }

    [Subject(typeof(Common.Logging.ILog)), Tags("Infrastructure.Log", "Issue"), Ignore(null)] // BUG : MSpec�� Ignore Attribute�� �ڱ� reason���� �����ϳ�...
    public class when_given_common_logging_logger
    {
        public static Common.Logging.ILog logger = Common.Logging.LogManager.GetCurrentClassLogger();

        // BUG : Common.Logging.LogManager.GetCurrentClassLogger�� Client�� Class���� �ùٸ��� �������� ���Ѵ�.
        It should_offered_a_right_callsite_info = () => logger.Warn("This is a log at DIRECTLY common.logging message!, but its callsite msg is a [Common.Logging.NLog.NLogLogger.WriteInternal]");
    }

    [Subject(typeof(ILog)), Tags("Infrastructure.Log")]
    public class when_given_a_logger_from_log_factory
    {
        public static readonly ILog logger =
            LogFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        It can_write_log_message_for_trace_level = () => { if (logger.IsTraceEnabled) logger.Trace("This is a log message for TRACE level"); };
        It can_write_log_message_for_debug_level = () => { if (logger.IsDebugEnabled) logger.Debug("This is a log message for DEBUG level"); };
        It can_write_log_message_for_info_level = () => { if (logger.IsInfoEnabled) logger.Info("This is a log message for INFO level"); };
        It can_write_log_message_for_warn_level = () => { if (logger.IsWarnEnabled) logger.Warn("This is a log message for WARN level"); };
        It can_write_log_message_for_error_level = () => { if (logger.IsErrorEnabled) logger.Error("This is a log message for ERROR level"); };
        It can_write_log_message_for_fatal_level = () => { if (logger.IsFatalEnabled) logger.Fatal("This is a log message for FATAL level"); };

        It can_write_log_message_as_format_string_for_trace_level = () => { if (logger.IsTraceEnabled) logger.Trace("This is a log message for {0} level", "TRACE"); };
        It can_write_log_message_as_format_string_for_debug_level = () => { if (logger.IsDebugEnabled) logger.Debug("This is a log message for {0} level", "DEBUG"); };
        It can_write_log_message_as_format_string_for_info_level = () => { if (logger.IsInfoEnabled) logger.Info("This is a log message for {0} level", "INFO"); };
        It can_write_log_message_as_format_string_for_warn_level = () => { if (logger.IsWarnEnabled) logger.Warn("This is a log message for {0} level", "WARN"); };
        It can_write_log_message_as_format_string_for_error_level = () => { if (logger.IsErrorEnabled) logger.Error("This is a log message for {0} level", "ERROR"); };
        It can_write_log_message_as_format_string_for_fatal_level = () => { if (logger.IsFatalEnabled) logger.Fatal("This is a log message for {0} level", "FATAL"); };

        It can_write_log_message_with_exception_for_trace_level = () => { if (logger.IsTraceEnabled) logger.Fatal("This is a log message for TRACE level with Exception", new InvalidOperationException()); };
        It can_write_log_message_with_exception_for_debug_level = () => { if (logger.IsDebugEnabled) logger.Fatal("This is a log message for DEBUG level with Exception", new InvalidOperationException()); };
        It can_write_log_message_with_exception_for_info_level = () => { if (logger.IsInfoEnabled) logger.Fatal("This is a log message for INFO level with Exception", new InvalidOperationException()); };
        It can_write_log_message_with_exception_for_warn_level = () => { if (logger.IsWarnEnabled) logger.Fatal("This is a log message for WARN level with Exception", new InvalidOperationException()); };
        It can_write_log_message_with_exception_for_error_level = () => { if (logger.IsErrorEnabled) logger.Fatal("This is a log message for ERROR level with Exception", new InvalidOperationException()); };
        It can_write_log_message_with_exception_for_fatal_level = () => { if (logger.IsFatalEnabled) logger.Fatal("This is a log message for FATAL level with Exception", new InvalidOperationException()); };
    }
}
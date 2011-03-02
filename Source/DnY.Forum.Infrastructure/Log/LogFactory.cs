using System;

namespace DnY.Forum.Infrastructure.Log
{
    /// <summary>
    /// Factory class for logging is done for system debug purposes. 
    /// </summary>
    /// <remarks>
    /// All other application logging necessary for application statistics is outside the scope of this module.
    /// </remarks>
    public class LogFactory
    {
        /// <summary>
        /// The method returns a logger for logger name
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetLogger(string loggerName)
        {
            return CommonLoggingLoggerProxy.GetLogger(loggerName);
        }
        /// <summary>
        /// The method returns a logger for logger type
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetLogger(Type type)
        {
            return CommonLoggingLoggerProxy.GetLogger(type);
        }

        /// <summary>
        /// The method returns a logger for Domain layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetDomainLayerLogger()
        {
            return CommonLoggingLoggerProxy.GetLogger("DomainLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for Application layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetApplicationLayerLogger()
        {
            return CommonLoggingLoggerProxy.GetLogger("ApplicationLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for Interface layer.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetInterfaceLayerLogger()
        {
            return CommonLoggingLoggerProxy.GetLogger("InterfaceLayerLogger");
        }

        /// <summary>
        /// The method returns a logger for External Service.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetExternalServiceLogger()
        {
            return CommonLoggingLoggerProxy.GetLogger("ExternalServiceLogger");
        }

        /// <summary>
        /// The method returns a logger for Specification.
        /// </summary>
        /// <returns>ILog</returns>
        public static ILog GetSpecificationLogger()
        {
            return CommonLoggingLoggerProxy.GetLogger("SpecificationLogger");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;


namespace WCFMVC.Utility.Log4net
{
    /// <summary>
    /// log4net的实现
    /// </summary>
    public class Log4netImpl : LogImpl, ILog4net
    {
        /// <summary>
        /// The fully qualified name of this declaring type not the type of any subclass.
        /// </summary>
        private readonly static Type ThisDeclaringType = typeof(Log4netImpl);


        public Log4netImpl(ILogger logger) : base(logger)
        {
        }

        #region ILog4net实现
        public void Debug(string operation, string action, object message)
        {
            Debug(operation, action, message, null);
        }

        public void Debug(string operation, string action, object message, Exception exception)
        {
            if (this.IsDebugEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Debug, message, exception);
                loggingEvent.Properties["Operation"] = operation;
                loggingEvent.Properties["Action"] = action;
                Logger.Log(loggingEvent);
            }
        }

        public void Error(string operation, string action, object message)
        {

            Error(operation, action, message, null);

            //throw new NotImplementedException();
        }

        public void Error(string operation, string action, object message, Exception exception)
        {
            if (this.IsErrorEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Error, message, exception);
                loggingEvent.Properties["Operation"] = operation;
                loggingEvent.Properties["Action"] = action;
                Logger.Log(loggingEvent);
            }
        }

        public void Fatal(string operation, string action, object message)
        {

            Fatal(operation, action, message, null);
        }

        public void Fatal(string operation, string action, object message, Exception exception)
        {
            if (this.IsFatalEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Fatal, message, exception);
                loggingEvent.Properties["Operation"] = operation;
                loggingEvent.Properties["Action"] = action;
                Logger.Log(loggingEvent);
            }
        }

        public void Info(string operation, string action, object message)
        {

            Info(operation, action, message, null);
            //throw new NotImplementedException();
        }

        public void Info(string operation, string action, object message, Exception exception)
        {
            if (this.IsInfoEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Info, message, exception);
                loggingEvent.Properties["Operation"] = operation;
                loggingEvent.Properties["Action"] = action;
                Logger.Log(loggingEvent);
            }
        }

        public void Warn(string operation, string action, object message)
        {
            Warn(operation, action, message, null);
        }

        public void Warn(string operation, string action, object message, Exception exception)
        {
            if (this.IsWarnEnabled)
            {
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Warn, message, exception);
                loggingEvent.Properties["Operation"] = operation;
                loggingEvent.Properties["Action"] = action;
                Logger.Log(loggingEvent);
            }
        }
        #endregion
    }
}

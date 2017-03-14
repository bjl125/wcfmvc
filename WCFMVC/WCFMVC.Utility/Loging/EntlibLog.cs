using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Web.Script.Serialization;

namespace WCFMVC.Utility.Loging
{
    public class EntlibLog : IEntlibLog
    {
        public void LogError(string message, params object[] args)
        {
            Write(LoggingCategory.Error, message, new Exception(message), args);
        }

        public void LogError(string title, Exception exp, params object[] args)
        {
            Write(LoggingCategory.Error,title, exp, args);
        }

        public void LogInfo(string title, object param, params object[] args)
        {
            string message = new JavaScriptSerializer().Serialize(param);
            Write(LoggingCategory.Information, title, new Exception(message), args);
        }

        public void LogInfo(string title, string message, params object[] args)
        {
            Write(LoggingCategory.Information, title, new Exception(message), args);
        }

        public void LogWarning(string message, params object[] args)
        {
            Write(LoggingCategory.Warning, message, new Exception(message), args);
        }

        void Write(LoggingCategory category, string title, Exception exception, params object[] args)
        {
            var properties = new Dictionary<string, object>();
            for(int i = 0; i < args.Length; i++)
            {
                properties.Add(string.Format("args{0}", i), args[i]);
            }
            LogEntry logent = new LogEntry(exception, category.ToString(), 0, 0, TraceEventType.Verbose, title, properties);
            Write(logent);
        }
        void Write(LogEntry logent)
        {
            Logger.Write(logent);
        }
    }

    public enum LoggingCategory
    {
        /// <summary>
        /// Information
        /// </summary>
        Information,

        /// <summary>
        /// Warning
        /// </summary>
        Warning,

        /// <summary>
        /// Error 
        /// </summary>
        Error,

        /// <summary>
        /// Exception
        /// </summary>
        Exception
    }
}

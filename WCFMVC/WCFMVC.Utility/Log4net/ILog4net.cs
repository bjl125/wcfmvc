using System;
using log4net;

namespace WCFMVC.Utility.Log4net
{
    /// <summary>
    /// 自定义log4net接口
    /// </summary>
    public interface ILog4net:ILog
    {
        void Debug(string operation, string action, object message);
        void Debug(string operation, string action, object message, Exception exception);

        void Info(string operation, string action, object message);
        void Info(string operation, string action, object message, Exception exception);


        void Warn(string operation, string action, object message);
        void Warn(string operation, string action, object message, Exception exception);


        void Error(string operation, string action, object message);
        void Error(string operation, string action, object message, Exception exception);


        void Fatal(string operation, string action, object message);
        void Fatal(string operation, string action, object message, Exception exception);
    }
}

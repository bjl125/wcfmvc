using System;


namespace WCFMVC.Utility.Loging
{
    public interface IEntlibLog
    {
        void LogInfo(string title, string message, params object[] args);

        void LogInfo(string title, object param, params object[] args);

        void LogWarning(string title, params object[] args);


        void LogError(string title, params object[] args);

        void LogError(string title, Exception exp, params object[] args);
    }
}

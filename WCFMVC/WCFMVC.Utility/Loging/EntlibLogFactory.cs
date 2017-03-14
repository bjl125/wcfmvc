using System;
using Microsoft.Practices.Unity;

namespace WCFMVC.Utility.Loging
{
    public static class EntlibLogFactory
    {
        static IEntlibLog _currentLogFactory { set; get; }

        [InjectionMethod]
        public static void SetCurrent(IEntlibLog log)
        {
            _currentLogFactory = log;
        }
        public static IEntlibLog Log
        {
            get
            {
                if (_currentLogFactory == null)
                    _currentLogFactory = new EntlibLog();
                return _currentLogFactory != null ? _currentLogFactory : null;
            }

        }
    }
}

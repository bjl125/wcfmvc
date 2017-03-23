using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Core;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using System.Reflection;

namespace WCFMVC.Utility.Log4net
{
    public class Log4netManager
    {
        /// <summary>
        /// The wrapper map to use to hold the <see cref="EventIDLogImpl"/> objects
        /// </summary>
        private static readonly WrapperMap s_wrapperMap = new WrapperMap(new WrapperCreationHandler(WrapperCreationHandler));

        /// <summary>
        /// Private constructor to prevent object creation
        /// </summary>
        private Log4netManager()
        {

        }
        #region WrapperHandler
        /// <summary>
        /// Method to create the <see cref="ILoggerWrapper"/> objects used by
        /// this manager.
        /// </summary>
        /// <param name="logger">The logger to wrap</param>
        /// <returns>The wrapper for the logger specified</returns>
        private static ILoggerWrapper WrapperCreationHandler(ILogger logger)
        {
            return new Log4netImpl(logger);
        }

        /// <summary>
        /// Lookup the wrapper object for the logger specified
        /// </summary>
        /// <param name="logger">the logger to get the wrapper for</param>
        /// <returns>the wrapper for the logger specified</returns>
        private static ILog4net WrapLogger(ILogger logger)
        {
            return (ILog4net)s_wrapperMap.GetWrapper(logger);
        }
        /// <summary>
        /// Lookup the wrapper objects for the loggers specified
        /// </summary>
        /// <param name="loggers">the loggers to get the wrappers for</param>
        /// <returns>Lookup the wrapper objects for the loggers specified</returns>
        private static ILog4net[] WrapLoggers(ILogger[] loggers)
        {
            ILog4net[] results = new ILog4net[loggers.Length];
            for(int i = 0; i < loggers.Length; i++)
            {
                results[i] = WrapLogger(loggers[i]);
            }
            return results;
        }
        #endregion

        #region Manager Methods

        /// <summary>
        /// Returns the named logger if it exists.
        /// </summary>
        /// <remarks>
        /// If the named logger exists (in the specified assembly's repository) then it returns a reference to the logger, otherwise it returns null.
        /// </remarks>
        /// <param name="name">The fully qualified logger name to look for.</param>
        /// <returns>The logger found, or null if the named logger does not exist in the specified assembly's repository.</returns>
        public static ILog4net Exists(string name)
        {
            return Exists(Assembly.GetCallingAssembly(), name);
        }

        /// <summary>
        /// Returns the named logger if it exists.
        /// </summary>
        /// <remarks>
        /// If the named logger exists (in the specified assembly's repository) then it returns a reference to the logger, otherwise it returns null.
        /// </remarks>
        /// <param name="domain">The repository to lookup in.</param>
        /// <param name="name">The fully qualified logger name to look for.</param>
        /// <returns>The logger found, or null if the named logger does not exist in the specified assembly's repository.</returns>
        public static ILog4net Exists(string domain,string name)
        {
            return WrapLogger(LoggerManager.Exists(domain, name));
        }
        /// <summary>
        /// Returns the named logger if it exists.
        /// </summary>
        /// <remarks>
        /// If the named logger exists (in the specified assembly's repository) then it returns a reference to the logger, otherwise it returns null.
        /// </remarks>
        /// <param name="assembly">The assembly to use to lookup the repository.</param>
        /// <param name="name">The fully qualified logger name to look for.</param>
        /// <returns>The logger found, or null if the named logger does not exist in the specified assembly's repository.</returns>
        public static ILog4net Exists(Assembly assembly,string name)
        {
            return WrapLogger(LoggerManager.Exists(assembly, name));
        }
        /// <summary>
        /// Retrieves or creates a named logger.
        /// </summary>
        /// <remarks>
        /// Retrieves a logger named as the name parameter. If the named logger already exists, then the existing instance will be returned. Otherwise, a new instance is created.
        /// By default, loggers do not have a set level but inherit it from the hierarchy.This is one of the central features of log4net.
        /// </remarks>
        /// <param name="name">The name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(string name)
        {
            return WrapLogger(LoggerManager.GetLogger(Assembly.GetCallingAssembly(), name));
        }
        /// <summary>
        /// Retrieves or creates a named logger.
        /// </summary>
        /// <remarks>
        /// Retrieves a logger named as the name parameter. If the named logger already exists, then the existing instance will be returned. Otherwise, a new instance is created.
        /// By default, loggers do not have a set level but inherit it from the hierarchy.This is one of the central features of log4net.
        /// </remarks>
        /// <param name="domain">The repository to lookup in.</param>
        /// <param name="name">The name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(string domain,string name)
        {
            return WrapLogger(LoggerManager.GetLogger(domain, name));
        }
        /// <summary>
        /// Retrieves or creates a named logger.
        /// </summary>
        /// <remarks>
        /// Retrieves a logger named as the name parameter. If the named logger already exists, then the existing instance will be returned. Otherwise, a new instance is created.
        /// By default, loggers do not have a set level but inherit it from the hierarchy.This is one of the central features of log4net.
        /// </remarks>
        /// <param name="assemlby">The assembly to use to lookup the repository.</param>
        /// <param name="name">The name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(Assembly assemlby,string name)
        {
            return WrapLogger(LoggerManager.GetLogger(assemlby, name));
        }

        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <remarks>
        /// Gets the logger for the fully qualified name of the type specified.
        /// </remarks>
        /// <param name="type">The type of which the fullname will be used as the name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(Type type)
        {
            return GetLogger(Assembly.GetCallingAssembly(), type);
        }
        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <remarks>
        /// Gets the logger for the fully qualified name of the type specified.
        /// </remarks>
        /// <param name="domain">The repository to lookup in.</param>
        /// <param name="type">The type of which the fullname will be used as the name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(string domain,Type type)
        {
            return WrapLogger(LoggerManager.GetLogger(domain, type));
        }
        /// <summary>
        /// Shorthand for <see cref="LogManager.GetLogger(string)"/>.
        /// </summary>
        /// <remarks>
        /// Gets the logger for the fully qualified name of the type specified.
        /// </remarks>
        /// <param name="assembly">the assembly to use to lookup the repository</param>
        /// <param name="type">The type of which the fullname will be used as the name of the logger to retrieve.</param>
        /// <returns>The logger with the name specified.</returns>
        public static ILog4net GetLogger(Assembly assembly, Type type)
        {
            return WrapLogger(LoggerManager.GetLogger(assembly, type));
        }

        /// <summary>
        /// Returns all the currently defined loggers in the default domain.
        /// </summary>
        /// <remarks>
        /// <para>The root logger is <b>not</b> included in the returned array.</para>
        /// </remarks>
        /// <returns>All the defined loggers</returns>
        public static ILog4net[] GetCurrentLoggers()
        {
            return GetCurrentLoggers(Assembly.GetCallingAssembly());
        }

        /// <summary>
        /// Returns all the currently defined loggers in the specified domain.
        /// </summary>
        /// <param name="domain">the domain to lookup in</param>
        /// <remarks>
        /// The root logger is <b>not</b> included in the returned array.
        /// </remarks>
        /// <returns>All the defined loggers</returns>
        public static ILog4net[] GetCurrentLoggers(string domain)
        {
            return WrapLoggers(LoggerManager.GetCurrentLoggers(domain));
        }

        /// <summary>
        /// Returns all the currently defined loggers in the specified assembly's domain.
        /// </summary>
        /// <param name="assembly">the assembly to use to lookup the domain</param>
        /// <remarks>
        /// The root logger is <b>not</b> included in the returned array.
        /// </remarks>
        /// <returns>All the defined loggers</returns>
        public static ILog4net[] GetCurrentLoggers(Assembly assembly)
        {
            return WrapLoggers(LoggerManager.GetCurrentLoggers(assembly));
        }
        #endregion


    }
}

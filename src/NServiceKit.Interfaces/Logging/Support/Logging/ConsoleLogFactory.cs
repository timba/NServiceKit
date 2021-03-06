#if !NETFX_CORE
using System;

namespace NServiceKit.Logging.Support.Logging
{
    /// <summary>
    /// Creates a Console Logger, that logs all messages to: System.Console
    /// 
    /// Made public so its testable
    /// </summary>
	public class ConsoleLogFactory : ILogFactory
    {
        /// <summary>Gets the logger.</summary>
        ///
        /// <param name="type">The type.</param>
        ///
        /// <returns>The logger.</returns>
        public ILog GetLogger(Type type)
        {
            return new ConsoleLogger(type);
        }

        /// <summary>Gets the logger.</summary>
        ///
        /// <param name="typeName">Name of the type.</param>
        ///
        /// <returns>The logger.</returns>
        public ILog GetLogger(string typeName)
        {
			return new ConsoleLogger(typeName);
        }
    }
}
#endif

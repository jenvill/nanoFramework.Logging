//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using Microsoft.Extensions.Logging;

namespace nanoFramework.Logging.Debug
{
    /// <summary>
    /// Provides a simple Debugger logger
    /// </summary>
    public class DebugLoggerFactory : ILoggerFactory
    {
        private readonly LogLevel _minLogLevel;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minLogLevel"></param>
        public DebugLoggerFactory(LogLevel minLogLevel = LogLevel.Debug) => _minLogLevel = minLogLevel;

        /// <inheritdoc/>
        public ILogger CreateLogger(string categoryName, LogLevel minLogLevel = LogLevel.Debug) 
            => new DebugLogger(categoryName, minLogLevel);

        /// <inheritdoc/>
        public ILogger CreateLogger(string categoryName) => new DebugLogger(categoryName, _minLogLevel);

        /// <inheritdoc />
        public void Dispose()
        {
            // nothing to do here
        }
    }
}
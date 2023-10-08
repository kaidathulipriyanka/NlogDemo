using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace NLogDemo
{
    public class NLog
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Logs the debug.
        /// </summary>
        /// <param name="messsage">The messsage.</param>
        public void LogDebug(String messsage)
        {
            log.Debug(messsage);
            
        }
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="messsage">The messsage.</param>
        public void LogError(String messsage) {
            log.Error(messsage);
        }

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="messsage">The messsage.</param>
        public void LogInfo(String messsage)
        {
            log.Info(messsage);
        }
        /// <summary>
        /// Logs the warn.
        /// </summary>
        /// <param name="messsage">The messsage.</param>
        public void LogWarn (String messsage)
        {
            log.Warn(messsage);
        }

    }
}      

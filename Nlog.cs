using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NlogDemo
{
    public class Nlog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebugTheMessage(string message)
        {
            logger.Debug(message);
        }
        public void LogErrorThemessage(string message)
        {
            logger.Error(message);
        }
        public void LogInfoTheMessage(string message)
        {
            logger.Info(message);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logtest
{
    class Applog
    {
        public static void LogDebug(string modle, string logMsg, Exception ex = null)
        {
            LogHelper log = LogFactory.GetLogger(modle);
            if (ex == null) log.Debug(logMsg);
            else log.Debug(logMsg, ex);

        }
        public static void LogInfo(string modle, string logMsg, Exception ex = null)
        {
            LogHelper log = LogFactory.GetLogger(modle);
            if (ex == null) log.Info(logMsg);
            else log.Info(logMsg, ex);
        }
        public static void LogWarn(string modle, string logMsg, Exception ex = null)
        {
            LogHelper log = LogFactory.GetLogger(modle);
            if (ex == null) log.Warn(logMsg);
            else log.Warn(logMsg, ex);
        }
        public static void LogError(string modle, string logMsg, Exception ex = null)
        {
            LogHelper log = LogFactory.GetLogger(modle);
            if (ex == null) log.Error(logMsg);
            else log.Error(logMsg, ex);
        }






    }
}

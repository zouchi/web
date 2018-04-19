using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.IO;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace logtest
{

    public class LogHelper
    {
        private readonly ILog _logger;

        public LogHelper(ILog log)
        {
            this._logger = log;
        }

        public void Debug(object message)
        {
            this._logger.Debug( message);
        }
        public void Debug(object message, Exception e)
        {
            this._logger.Debug(message, e);
        }

        public void Error(object message)
        {
            this._logger.Error( message);
        }
        public void Error(object message, Exception e)
        {
            this._logger.Error( message, e);
        }

        public void Info(object message)
        {
            this._logger.Info( message);
        }
        public void Info(object message, Exception e)
        {
            this._logger.Info( message, e);
        }

        public void Warn(object message)
        {
            this._logger.Warn( message);
        }
        public void Warn(object message, Exception e)
        {
            this._logger.Warn( message, e);
        }

        public void Fatal(object message)
        {
            this._logger.Fatal( message);
        }
        public void Fatal(object message, Exception e)
        {
            this._logger.Fatal(message, e);
        }

    }
    public class LogFactory
    {

        public static LogHelper GetLogger(Type type)
        {
            return new LogHelper(LogManager.GetLogger(type));
        }

        public static LogHelper GetLogger(string str)
        {
            return new LogHelper(LogManager.GetLogger(str));
        }








    }



}
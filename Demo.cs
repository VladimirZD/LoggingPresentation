using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingTipsTricks
{
    public class Demo : DemoBase
    {
        public NLog.Logger LoggerLocal = NLog.LogManager.GetCurrentClassLogger();

        public Demo()
        {
            LoggerLocal.Info("Hi from demo");
            LoggerLocal.Info($"Ovo traje dulje od 10 sekundi");
            base.Logger.Info("Hi from demo");
        }
    }
}

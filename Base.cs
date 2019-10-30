using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingTipsTricks
{
    public class DemoBase
    {
        public NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public Guid ID { get; set; }

        public DemoBase()
        {
            ID = Guid.NewGuid();
            Logger.Info("Hi from base");
        }
    }
}
